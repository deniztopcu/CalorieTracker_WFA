using CalorieTracking.BLL;
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


        public AddFoodScreen(User user)
        {
            InitializeComponent();
            foodService = new FoodService();
            categoryService = new CategoryService();
            _user = user;

        }
        User _user;

        private void AddFoodScreen_Load(object sender, EventArgs e)
        {
            ButtonControls(true);

            GetFoods(_user);

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
        private void GetFoods(User user)
        {
            int userID = user.ID;
            lstFoods.Items.Clear();
            var foods = foodService.GetAllFoods(userID);

            foreach (Food food in foods)
            {
                string[] foodInfo = { food.ID.ToString(), food.UserID.ToString(), food.Name, food.Calorie.ToString(), food.PortionGram.ToString(), food.PortionName.ToString() };

                ListViewItem lvi = new(foodInfo);
                lvi.Tag = food.ID;

                lstFoods.Items.Add(lvi);
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string foodName = txtFoodName.Text;

            if (txtFoodName.Text == string.Empty)
            {
                MessageBox.Show("Food name cannot be left blank!");
            }
            else
            {
                if (foodService.CheckEntries(foodName))
                {
                    MessageBox.Show("Has been recorded before!");
                }
                else
                {
                    int userID = _user.ID;
                    int categoryID = ((Category)cbCategory.SelectedItem).ID;
                    Food food = new Food();
                    food.Name = txtFoodName.Text;
                    food.Calorie = float.Parse(txtCalorie.Text);
                    food.CategoryID = categoryID;
                    food.UserID = userID;
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
                    GetFoods(_user);
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

        private void lstFoods_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstFoods.SelectedItems.Count > 0)
            {
                int foodID = (int)lstFoods.SelectedItems[0].Tag;
                Food food = foodService.GetFoodByID(foodID);
                var category = categoryService.GetById(food.CategoryID);
                var portionName = food.PortionName.ToString();
                txtFoodName.Text = food.Name;
                txtCalorie.Text = food.Calorie.ToString();
                txtGram.Text = food.PortionGram.ToString();
                cbPortionType.SelectedItem = food.PortionName;
                cbCategory.SelectedItem = category;
                //pbFoodImage.Image = Image.FromFile(Application.StartupPath + food.Picture);
                ButtonControls(false);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string foodName = txtFoodName.Text;

            if (txtFoodName.Text == string.Empty)
            {
                MessageBox.Show("Food name cannot be left blank!");
            }
            else
            {


                int userID = _user.ID;
                int categoryID = ((Category)cbCategory.SelectedItem).ID;
                int foodID=(int)lstFoods.SelectedItems[0].Tag;
                Food food = foodService.GetFoodByID(foodID);
                food.Name = txtFoodName.Text;
                food.Calorie = float.Parse(txtCalorie.Text);
                food.CategoryID = categoryID;
                food.UserID = userID;
                food.PortionName = (PortionNames)cbPortionType.SelectedIndex;
                food.PortionGram = float.Parse(txtGram.Text);
                string path = "";
                if (pbFoodImage.Tag != null)
                {
                    path = Guid.NewGuid() + pbFoodImage.Tag.ToString();
                    pbFoodImage.Image.Save(Application.StartupPath + "\\FoodPhotos\\" + path);
                }
                food.Picture = "\\FoodPhotos\\" + path;

                foodService.Update(food);
                MessageBox.Show("Successful");
                GetFoods(_user);
                ClearItems(gbxAddFood.Controls);
            }
        }

    }
}

