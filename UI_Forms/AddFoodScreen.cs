﻿using CalorieTracking.BLL;
using CaloriTracker.DAL.Repositories.Concrete;
using Models.Concrete;
using Models.Enums;
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
    public partial class AddFoodScreen : Form
    {
        
        FoodService foodService;
        CategoryService categoryService;
        

        public AddFoodScreen()
        {
            InitializeComponent();
            foodService = new FoodService();
            categoryService = new CategoryService();
   
        }
        

        private void AddFoodScreen_Load(object sender, EventArgs e)
        {
            var categories = categoryService.GetAllCategories();
          

            foreach (var category in categories)
            {
                cbCategory.Items.Add(category);
            }

            
            PortionNames[] portionNames = (PortionNames[])Enum.GetValues(typeof(PortionNames));

            
            foreach (PortionNames portion in portionNames)
            {
                cbPortionType.Items.Add(portion.ToString());
            }



        }

        public void ButtonControls(bool status)
        {
            btnAdd.Enabled = status;
            btnDelete.Enabled = !status;
            btnUpdate.Enabled = !status;
        }

        private void FillLvItems(Food food)
        {
           // lstFoods.Items.Clear();
           // var foods = foodService.GetAllPassiveFoods(_user.ID);

    
            
                ListViewItem lv = new ListViewItem(food.ID.ToString());
                lv.SubItems.Add(food.ID.ToString());
                lv.SubItems.Add(food.Name);
                lv.SubItems.Add(food.Calorie.ToString());
                lv.SubItems.Add(food.PortionGram.ToString());
                lv.SubItems.Add(food.PortionName.ToString());
                lv.SubItems.Add(food.Category.CategoryName);
                lstFoods.Items.Add(lv);
                lv.Tag = food;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string foodName = txtFoodName.Text;

            if (txtFoodName.Text == string.Empty)
            {
                MessageBox.Show("Nutrition name cannot be left blank!");
            }
            else
            {
                if (foodService.CheckEntries(foodName))
                {
                    MessageBox.Show("Has been recorded before!");
                }
                else
                {
                    Food food = new Food();
                    food.Name = txtFoodName.Text;
                    food.Calorie = float.Parse(txtCalorie.Text);
                    food.CategoryID = ((Category)cbCategory.SelectedItem).ID;
                    food.Category= (Category)cbCategory.SelectedItem;
                    food.PortionName = (PortionNames)cbPortionType.SelectedIndex;
                    food.PortionGram = float.Parse(txtGram.Text);
                    string path = "";
                    if (pbFoodImage.Tag != null)
                    {
                        path = Guid.NewGuid() + pbFoodImage.Tag.ToString();
                        pbFoodImage.Image.Save(Application.StartupPath + "\\FoodPhotos\\" + path);
                    }
                    food.Picture = "\\FoodPhotos\\" + path;

                    foodService.Add(food);
                    MessageBox.Show("Successful");
                    //FillLvItems(food);
                    ClearItems(gbxAddFood.Controls);
                }
            }


        }

        private void ClearItems(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedItem = -1;
                }
            }
        }

        private void pbFoodImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Yemek Fotografi(png,jpg,gif)|*.png;*.jpg;*.gif";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pbFoodImage.Image = Image.FromFile(ofd.FileName);

                pbFoodImage.Tag = Path.GetExtension(ofd.FileName);
            }
        }
    }
}
