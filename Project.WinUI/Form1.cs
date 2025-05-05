using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAL.ContextClasses;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Validation;



namespace Project.WinUI
{
    public partial class Form1 : Form
    {

        MyContext db = new MyContext();
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'e kitapları kategorisiyle birlikte yükle
                DgvBooks.DataSource = db.Books.Include(x => x.Category).ToList();

                // ComboBox'a kategorileri yükle
                CmbCategories.DataSource = db.Categories.ToList();
                CmbCategories.DisplayMember = "CategoryName";
                CmbCategories.ValueMember = "ID";
                CmbCategories.SelectedIndex = -1; // Başlangıçta boş olsun
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTitle.Text) || string.IsNullOrEmpty(TxtAuthor.Text) ||
        string.IsNullOrEmpty(TxtPrice.Text) || string.IsNullOrEmpty(TxtPageCount.Text) ||
        CmbCategories.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve geçerli bir kategori seçin.");
                return;
            }

            Book newBook = new Book
            {
                Title = TxtTitle.Text,
                Author = TxtAuthor.Text,
                UnitPrice = Convert.ToDecimal(TxtPrice.Text),
                PageCount = int.Parse(TxtPageCount.Text),
                CategoryID = (int)CmbCategories.SelectedValue
            };

            db.Books.Add(newBook);
            db.SaveChanges();

            MessageBox.Show("Kitap eklendi.");
            DgvBooks.DataSource = db.Books.Include(x => x.Category).ToList();
        }

        private void BtnLoan_Click(object sender, EventArgs e)
        {
            // 1. Alanların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(TxtMember.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtPhone.Text) ||
                string.IsNullOrWhiteSpace(TxtBookIdForLoan.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.");
                return;
            }

            // 2. Kitap ID'si geçerli mi kontrol et
            if (!int.TryParse(TxtBookIdForLoan.Text, out int bookId))
            {
                MessageBox.Show("Geçerli bir kitap ID girin.");
                return;
            }

            try
            {
                // 3. Üye oluştur ve kaydet
                Member newMember = new Member
                {
                    FullName = TxtMember.Text,
                    Email = TxtEmail.Text,
                    Phone = TxtPhone.Text
                };

                db.Members.Add(newMember);
                db.SaveChanges(); // Üye kaydedildi

                // 4. Kitap var mı kontrol et
                Book bookToLoan = db.Books.Find(bookId);
                if (bookToLoan == null)
                {
                    MessageBox.Show("Girilen ID'ye sahip bir kitap bulunamadı.");
                    return;
                }

                // 5. Ödünç kaydı oluştur
                Loan newLoan = new Loan
                {
                    BookID = bookToLoan.Id,
                    MemberID = newMember.Id,
                    BorrowDate = DateTime.Now
                };

                db.Loans.Add(newLoan);
                db.SaveChanges();

                MessageBox.Show("Kitap başarıyla ödünç verildi.");
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var error in validationErrors.ValidationErrors)
                    {
                        sb.AppendLine($"Alan: {error.PropertyName} - Hata: {error.ErrorMessage}");
                    }
                }
                MessageBox.Show(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
