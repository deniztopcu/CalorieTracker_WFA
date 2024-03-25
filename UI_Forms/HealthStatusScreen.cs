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
    public partial class HealthStatusScreen : Form
    {
        UserDetailService userDetailService;
        User _user;

        public HealthStatusScreen(User user)
        {
            InitializeComponent();
            userDetailService = new UserDetailService();
            _user = user;
        }
        

        private void HealthStatusScreen_Load(object sender, EventArgs e)
        {

            lblUserAge.Text = (DateTime.Now.Year - userDetailService.GetById(_user.ID).BirthDate.Year).ToString();
            lblUserGender.Text = userDetailService.GetById(_user.ID).Gender.ToString();
            lblUserHeight.Text = userDetailService.GetById(_user.ID).Height.ToString();
            lblUserWeight.Text = userDetailService.GetById(_user.ID).Height.ToString();

            UserMealDetailService userMealDetailService = new UserMealDetailService();
            MealService mealService = new MealService();


        }

        private void lblUserGender_Click(object sender, EventArgs e)
        {

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbSedentary.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.2).ToString();
            if (rbLight.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.3).ToString();
            if (rbModerate.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.4).ToString();
            if (rbActive.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.5).ToString();

            double calorieNeed = double.Parse(lblCalorieNeed.Text);
            pbCalorieStatus.Maximum = (int)Math.Round(calorieNeed);
            double todayTotalCalorie = 0;


            if (todayTotalCalorie > pbCalorieStatus.Maximum)
            {
                pbCalorieStatus.Value = pbCalorieStatus.Maximum;
                MessageBox.Show("Günlük maksimum kaloriye ulaştınız!");
            }
            else
            {
                pbCalorieStatus.Value = (int)Math.Round(todayTotalCalorie);
            }
        }

        public double CalculateBMR()
        {
            double bMR = 0;
            if (lblUserGender.Text == "Male")
            {
                bMR = 66.5 + (13.75 * userDetailService.GetById(_user.ID).Weight) + (5 * userDetailService.GetById(_user.ID).Height) - (6.77 * (DateTime.Now.Year - userDetailService.GetById(_user.ID).BirthDate.Year));
            }
            else
            {
                bMR = 655.1 + (9.56 * userDetailService.GetById(_user.ID).Weight) + (1.85 * userDetailService.GetById(_user.ID).Height) - (4.67 * (DateTime.Now.Year - userDetailService.GetById(_user.ID).BirthDate.Year));
            }
            return bMR;
        }

    }
}
