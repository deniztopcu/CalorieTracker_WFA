using CalorieTracking.BLL;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI_Forms
{
    public partial class RegistorScreen : Form
    {
        public RegistorScreen()
        {
            InitializeComponent();
            userService = new UserService();
        }
        UserService userService;

        // Programa sadece 10 yaşından büyük kişilerin giriş yapabilmesini sağlar.
        private void RegistorScreen_Load(object sender, EventArgs e)
        {
            dtpDogumTarihi.MaxDate = DateTime.Now.AddYears(-10);
        }

        // Şifre görünürlüğünü değiştirir
        private void chbSifreGöster_CheckedChanged(object sender, EventArgs e)
        {

            if (chbSifreGöster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtTekrarSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
                txtTekrarSifre.PasswordChar = '*';
            }
        }

        private void btnKapat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void lnkHesapVarMı_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string email = txtEMail.Text;
            string password = txtSifre.Text;
            string confirmPassword = txtTekrarSifre.Text;

            // Kullanıcının sistemde olup olmadığını kotrol eder
            if (!userService.ControlEmail(email))
            {
                MessageBox.Show("Mail Adresi Sistemde Kayıtlıdır!");
                txtEMail.BackColor = Color.Coral;
                return;
            }
            else
                txtEMail.BackColor = SystemColors.Window;

            // Alanlara değer girilme durumunu kontrol eder.
            if (!ControlNullOrNot())
            {
                return;
            }
            // Kullanıcını geçerli bir parola girmesini ve gerekli diğer kontrolleri yapar.
            else if (ControlPassword(password, confirmPassword))
            {
                User user = new User()
                {
                    Email = email,
                    Password = sha256(password),
                    PasswordClue = txtIpucu.Text,
                    UserDetail = new UserDetail()
                    {
                        Name = txtAd.Text,
                        Surname = txtSoyad.Text,
                        Gender = (rbErkek.Checked ? Models.Enums.Genders.Male : Models.Enums.Genders.Female),
                        BirthDate = dtpDogumTarihi.Value,
                        Height = Convert.ToInt32(nudBoy.Value),
                        Weight = Convert.ToDouble(nudKilo.Value),
                    }
                };

                if (rbErkek.Checked == false && rbKadin.Checked == false)
                {
                    MessageBox.Show("Cinsiyet alanı boş bırakılamaz.");
                    return;
                }

                bool isAdded = userService.Add(user);
                if (!isAdded)
                {
                    MessageBox.Show("Kullanıcı eklenirken beklenmeyen bir hata oluştu");
                }
                else
                {
                    foreach (Control control in pnlKullanıcı.Controls)
                    {
                        if (control is TextBox)
                            ((TextBox)control).Text = "";
                    }

                    foreach (Control control in pnlKullanıcıBilgi.Controls)
                    {
                        if (control is RadioButton)
                            ((RadioButton)control).Checked = false;
                        else if (control is NumericUpDown)
                            ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum;
                        else if (control is DateTimePicker)
                            ((DateTimePicker)control).Value = DateTime.Today.AddYears(-10);
                    }

                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
        }

        /// <summary>
        /// Şifreyi hashler.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Hashlenmiş şifreyi döner.</returns>
        private string sha256(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        /// <summary>
        /// Kullanıcı Kayıt ekranındaki doldurulması gerekenalanların boş geçilmemesini sağlar.
        /// </summary>
        /// <returns>Boş Alan yoksa true döner varsa false döner.</returns>
        private bool ControlNullOrNot()
        {
            // Ad alanının boş girilmemesi sağlanır.
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                txtAd.BackColor = Color.Coral;
                MessageBox.Show("Ad alanı boş bırakılamaz");
                return false;
            }
            else
                txtAd.BackColor = SystemColors.Window;

            // Soyad alanının boş girilmemesi sağlanır.
            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                txtSoyad.BackColor = Color.Coral;
                MessageBox.Show("Soyad alanı boş bırakılamaz");
                return false;
            }
            else
                txtSoyad.BackColor = SystemColors.Window;

            // Mail Adresinin boş girilmemesi sağlanır.
            if (string.IsNullOrEmpty(txtEMail.Text))
            {
                txtEMail.BackColor = Color.Coral;
                MessageBox.Show("Email alanı boş bırakılamaz");
                return false;
            }
            else
                txtEMail.BackColor = SystemColors.Window;

            // Şifrenin boş girilmemesi sağlanır.
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                txtSifre.BackColor = Color.Coral;
                MessageBox.Show("Şifre boş bırakılamaz");
                return false;
            }
            else
                txtSifre.BackColor = SystemColors.Window;

            // Tekrar eden şifrenin boş girilmemesi sağlanır.
            if (string.IsNullOrEmpty(txtTekrarSifre.Text))
            {
                txtTekrarSifre.BackColor = Color.Coral;
                MessageBox.Show("Şifre tekrar alanı boş bırakılamaz");
                return false;
            }
            else
                txtTekrarSifre.BackColor = SystemColors.Window;

            return true;
        }

        /// <summary>
        /// Parola Kontrollerini yapar.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns>Parola uygun formattaysa true değilse false döner.</returns>
        public bool ControlPassword(string password, string confirmPassword)
        {
            string specialChar = "!@#$%^&*()-_+=<>?/,.:;{}[]|";
            int specialCharCount = password.Count(c => specialChar.Contains(c));

            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakterli olmalıdır!");
                txtSifre.ForeColor = Color.Red;
                return false;
            }
            else
                txtSifre.ForeColor = Color.Black;
            if (password.Count(char.IsUpper) < 1)
            {
                MessageBox.Show("Şifre içerisinde en az 1 büyük harf olmalıdır!");
                txtSifre.ForeColor = Color.Red;
                return false;
            }
            else
                txtSifre.ForeColor = Color.Black;
            if (password.Count(char.IsLower) < 1)
            {
                MessageBox.Show("Şifre içerisinde en az 1 küçük harf olmalıdır!");
                txtSifre.ForeColor = Color.Red;
                return false;
            }
            else
                txtSifre.ForeColor = Color.Black;
            if (specialCharCount < 1)
            {
                MessageBox.Show("Şifre içerisinde en az 1 özel karakter olmalıdır!");
                txtSifre.ForeColor = Color.Red;
                return false;
            }
            else
                txtSifre.ForeColor = Color.Black;

            //Şifrenin eşleşip eşleşmediği kontrol edilir.
            if (password != confirmPassword)
            {
                txtTekrarSifre.ForeColor = Color.Red;
                txtSifre.ForeColor = Color.Red;
                MessageBox.Show("Şifreler eşleşmelidir!");
                return false;
            }
            else
            {
                txtTekrarSifre.ForeColor = Color.Black;
                txtSifre.ForeColor = Color.Black;
            }
            return true;
        }

        // Formun mouse ile kaydırılmasını sağlayan kodlar
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();
    }
}
