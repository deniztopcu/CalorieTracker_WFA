using CalorieTracking.BLL;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Forms
{
    public partial class MainScreen : Form
    {
        UserService userService;
        LoginScreen loginScreen;
        User _user;
        public MainScreen(User user)
        {
            InitializeComponent();
            userService = new UserService();
            loginScreen = new LoginScreen();
            _user = user;
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

        private void MainScreen_Load(object sender, EventArgs e)
        {
            LoadHomeScreen();
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString();
           
        }

        public void LoadHomeScreen()
        {
            HomeScreen homeScreen = new HomeScreen(_user); 
            homeScreen.MdiParent = this;
            homeScreen.Dock = DockStyle.Fill;
            homeScreen.Show();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(homeScreen);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // lblTime.Text = DateTime.Now.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            LoadHomeScreen();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfoScreen userInfoScreen = new UserInfoScreen(_user); //user...
            userInfoScreen.MdiParent = this;
            userInfoScreen.Dock = DockStyle.Fill;
            userInfoScreen.Show();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userInfoScreen);
        }

        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScreen.Show();

            Application.Exit();

        }

        private void btnHealthStatus_Click(object sender, EventArgs e)
        {
                
                this.ActiveMdiChild.Close();
                HealthStatusScreen healthStatusScreen = new HealthStatusScreen(_user); //user
                healthStatusScreen.MdiParent = this;
                healthStatusScreen.Dock = DockStyle.Fill;
                healthStatusScreen.Show();
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(healthStatusScreen);
         
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();

            HistoryScreen historyScreen = new HistoryScreen(); //user
            historyScreen.MdiParent = this;
            historyScreen.Dock = DockStyle.Fill;
            historyScreen.Show();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(historyScreen);


            HealthStatusScreen healthStatusScreen = new HealthStatusScreen(_user); //user
            healthStatusScreen.MdiParent = this;
            healthStatusScreen.Dock = DockStyle.Fill;
            healthStatusScreen.Show();


        }

        private void btnAnalize_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();

            AnalizScreen analizScreen = new AnalizScreen(); //user
            analizScreen.MdiParent = this;
            analizScreen.Dock = DockStyle.Fill;
            analizScreen.Show();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(analizScreen);

        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();

            AddMealScreen addMealScreen = new AddMealScreen(); //user
            addMealScreen.MdiParent = this;
            addMealScreen.Dock = DockStyle.Fill;
            addMealScreen.Show();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(addMealScreen);

        }

        private void btnAddNutrition_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();

            AddFoodScreen addFoodScreen = new AddFoodScreen(); //user
            addFoodScreen.MdiParent = this;
            addFoodScreen.Dock = DockStyle.Fill;
            addFoodScreen.Show();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(addFoodScreen);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

            HealthStatusScreen healthStatusScreen = new HealthStatusScreen(_user); //user
            healthStatusScreen.MdiParent = this;
            healthStatusScreen.Dock = DockStyle.Fill;
            healthStatusScreen.Show();


        }
    }
}
