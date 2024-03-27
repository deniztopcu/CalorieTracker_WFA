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
        private void RegistorScreen_Load(object sender, EventArgs e)
        {
            // Programa sadece 10 yaşından büyük kişilerin giriş yapabilmesini sağlar.
            dtpDogumTarihi.MaxDate = DateTime.Now.AddYears(-10);
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            ControlNullOrNot();
            //user bilgileri
            string email = txtEMail.Text;
            string password = txtSifre.Text;
            string confirmPassword = txtTekrarSifre.Text;

            if (!userService.ControlEmail(email))
            {
                MessageBox.Show("Mail Adresi Sistemde Kayıtlıdır!");
                return;
            }

            if (!ControlPassword(password))
            {
                return;
            }

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

            bool isAdded = userService.Add(user);
            if (!isAdded)
            {
                MessageBox.Show("Kullanıcı eklenirken beklenmeyen bir hata oluştu");
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı!");
            }
        }

        private string sha256(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

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

        public bool ControlPassword(string password)
        {
            string specialChar = "!@#$%^&*()-_+=<>?/,.:;{}[]|";
            int specialCharCount = password.Count(c => specialChar.Contains(c));

            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakterli olmalıdır!");
                return false;
            }
            else if (password.Count(char.IsUpper) < 1)
            {
                MessageBox.Show("Şifre içerisinde en az 1 büyük harf olmalıdır!");
                return false;
            }
            else if (password.Count(char.IsLower) < 1)
            {
                MessageBox.Show("Şifre içerisinde en az 1 küçük harf olmalıdır!");
                return false;
            }
            else if (specialCharCount < 1)
            {
                MessageBox.Show("Şifre içerisinde en az 1 özel karakter olmalıdır!");
                return false;
            }
            //Şifrenin eşleşip eşleşmediği kontrol edilir.
            else if (txtSifre.Text != txtTekrarSifre.Text)
            {
                txtTekrarSifre.ForeColor = Color.Red;
                txtSifre.ForeColor = Color.Red;
                MessageBox.Show("Şifreler eşleşmelidir!");
                return false;
            }
            else
            {
                txtTekrarSifre.BackColor = SystemColors.Window;
                txtSifre.BackColor = SystemColors.Window;
            }
            return true;
        }

        private void btnKapat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void lnkHesapVarMı_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
   
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
