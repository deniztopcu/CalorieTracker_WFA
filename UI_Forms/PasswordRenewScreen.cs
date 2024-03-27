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

namespace UI_Forms
{
    public partial class PasswordRenewScreen : Form
    {
        public PasswordRenewScreen()
        {
            InitializeComponent();
            userService = new();
        }
        UserService userService;
        private void PasswordRenewScreen_Load(object sender, EventArgs e)
        {
            txtEmail.Font = new Font("Century Gothic", 12);
            txtYeniSifre.Enabled = false;
            btnUpdatePassword.Enabled = false;
            txtYeniSifre.Font = new Font("Century Gothic", 12);
            txtYeniSifre.PasswordChar = '•';
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtYeniSifre.Text;


            if (password.Length < 8)
            {
                MessageBox.Show("Şifre uzunluğu en az 8 karakter olmalıdır!");
                return;
            }
            if (password.Count(char.IsUpper) < 1)
            {
                MessageBox.Show("Şifre en az 1 büyük harf karakter içermelidir!");
                return;
            }
            if (password.Count(char.IsLower) < 1)
            {
                MessageBox.Show("Şifre en az 1 küçük harf içermelidir!");
                return;
            }

            string specialChar = "!:+*";
            int specialCharCount = password.Count(c => specialChar.Contains(c));

            if (specialCharCount < 1)
            {
                MessageBox.Show("Şifre en az 1 özel karakter içermelidir!");
                return;
            }

            password = sha256(txtYeniSifre.Text);

            User user = userService.CheckInfo(email);
            User selectedUser = userService.UserByUserId(user.ID);
            selectedUser.Password = password;
            userService.Update(selectedUser);
            MessageBox.Show("Şifre başarıyla güncellendi");
            this.Close();
        }

        private string sha256(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

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

        private void chbSifreyiGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifreyiGöster.Checked)
            {
                txtYeniSifre.UseSystemPasswordChar = true;
            }
            else
            {
                txtYeniSifre.UseSystemPasswordChar = false;
            }
        }

        private void btnCheckInfos_Click(object sender, EventArgs e)
        {
            ControlNullOrNot();
            string email = txtEmail.Text;
            string ipucu = txtIpucu.Text;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                return;
            }
            else
            {
                txtEmail.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtIpucu.Text))
            {
                txtIpucu.BackColor = Color.Red;
                return;
            }
            else
            {
                txtIpucu.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtIpucu.Text))
            {
                txtIpucu.BackColor = Color.Red;
                return;
            }
            else
            {
                txtIpucu.BackColor = SystemColors.Window;
            }

            UserDetailService userDetail = new UserDetailService();

            User user = userService.CheckInfo(email,ipucu);

            if (user != null)
            {
                btnUpdatePassword.Enabled = true;
                txtYeniSifre.Enabled = true;
            }
            else
            {
                MessageBox.Show("User information is invalid");
            }
        }

        private void ControlNullOrNot()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                return;
            }
            else
            {
                txtEmail.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtIpucu.Text))
            {
                txtIpucu.BackColor = Color.Red;
                return;
            }
            else
            {
                txtIpucu.BackColor = SystemColors.Window;
            }
        }
    } 
}
