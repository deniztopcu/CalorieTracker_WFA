using CalorieTracking.BLL;
using Models.Concrete;
using System.Security.Cryptography;
using System.Text;

namespace UI_Forms
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            userService = new UserService();

        }
        UserService userService;
        private void UserEntranceScreen_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lklbl_HesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistorScreen registerScreen = new RegistorScreen();
            registerScreen.ShowDialog();
        }

        private void btnKapat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            string password = sha256(txt_Password.Text);
            string email = txt_Mail.Text;

            User user = userService.ControlUser(email, password);

            if (user != null)
            {

                MainScreen mainScreen = new MainScreen(); //user ve this unutma

                mainScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email or password is incorrect. Please try again!");
            }
        }

        private string sha256(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
            {
                txt_Password.PasswordChar = '\0';

            }
            else
            {
                txt_Password.PasswordChar = '*';

            }
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

        private void lnkIpucuGoster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = txt_Mail.Text;
            if (email is not null )
            {
                if (!userService.ControlEmail(email))
                {
                    lblIpucu.Text = userService.SendPasswordClue(email);
                   
                }
            }
        }
    }
}

