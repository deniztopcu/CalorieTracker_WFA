﻿using System;
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
        public HealthStatusScreen()
        {
            InitializeComponent();
        }

        private void HealthStatusScreen_Load(object sender, EventArgs e)
        {

            //lblUserAge.Text = (DateTime.Now.Year - user.UserDetail.BirthDate.Year).ToString();
            //lblUserGender.Text = user.UserDetail.Gender.ToString();
            //lblUserHeight.Text = user.UserDetail.Height.ToString();
            //lblUserWeight.Text = user.UserDetail.Weight.ToString();

            //UserMealDetailService userMealDetailService = new UserMealDetailService();
            //MealService mealService = new MealService();
          

        }

        private void lblUserGender_Click(object sender, EventArgs e)
        {

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
        //    if (rbSedentary.Checked)
        //        lblCalorieNeed.Text = (CalculateBMR() * 1.2).ToString();
        //    if (rbLight.Checked)
        //        lblCalorieNeed.Text = (CalculateBMR() * 1.3).ToString();
        //    if (rbModerate.Checked)
        //        lblCalorieNeed.Text = (CalculateBMR() * 1.4).ToString();
        //    if (rbActive.Checked)
        //        lblCalorieNeed.Text = (CalculateBMR() * 1.5).ToString();

        //    double calorieNeed = double.Parse(lblCalorieNeed.Text);
        //    pbCalorieStatus.Maximum = (int)Math.Round(calorieNeed);
        //    double todayTotalCalorie = 0;
           

        //    if (todayTotalCalorie > pbCalorieStatus.Maximum)
        //    {
        //        pbCalorieStatus.Value = pbCalorieStatus.Maximum;
        //        MessageBox.Show("You have reach to maximum calorie!");
        //    }
        //    else
        //    {
        //        pbCalorieStatus.Value = (int)Math.Round(todayTotalCalorie);
        //    }
        }

        //public double CalculateBMR()
        //{
        //    double bMR = 0;
        //    if (lblUserGender.Text == "Male")
        //    {
        //        bMR = 66.5 + (13.75 * user.UserDetail.Weight) + (5 * user.UserDetail.Height) - (6.77 * (DateTime.Now.Year - user.UserDetail.BirthDate.Year));
        //    }
        //    else
        //    {
        //        bMR = 655.1 + (9.56 * user.UserDetail.Weight) + (1.85 * user.UserDetail.Height) - (4.67 * (DateTime.Now.Year - user.UserDetail.BirthDate.Year));
        //    }
        //    return bMR;
        //}

    }
}