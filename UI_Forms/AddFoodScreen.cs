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

        /// <summary>
        /// Girilmesi zorunlu alanların boş olup olmadığını kontrol eder.
        /// </summary>
        /// <returns>Boş alan varsa false yoksa true döner.</returns>
        private bool ControlNullOrNot()
        {
            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                txtFoodName.BackColor = Color.Coral;
                MessageBox.Show("Lütfen bir yemek ismi giriniz.");
                return false;
            }
            else
                txtFoodName.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(txtCalorie.Text))
            {
                txtCalorie.BackColor = Color.Coral;
                MessageBox.Show("Lütfen kalori giriniz.");
                return false;
            }
            else
                txtCalorie.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(txtGram.Text))
            {
                txtGram.BackColor = Color.Coral;
                MessageBox.Show("Lütfen gram bilgisi giriniz.");
                return false;
            }
            else
                txtGram.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(cbPortionType.Text))
            {
                cbPortionType.BackColor = Color.Coral;
                MessageBox.Show("Lütfen porsiyon tipi seçiniz.");
                return false;
            }
            else
                cbPortionType.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(cbCategory.Text))
            {
                cbCategory.BackColor = Color.Coral;
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return false;
            }
            else
                cbCategory.BackColor = SystemColors.Window;

            return true;
        }

        public void ButtonControls(bool status)
        {
            //btnAdd.Enabled = status;
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

            if (!ControlNullOrNot())
            {
                return;
            }
            if (!IsNumeric(txtCalorie.Text) || !IsNumeric(txtGram.Text))
            {
                MessageBox.Show("Lütfen kalori ve gram alanlarına nümerik bir değer giriniz.");
                return;
            }
            else
            {
                if (foodService.CheckEntries(foodName))
                {
                    MessageBox.Show("Yemek sistemde kayıtlı!");
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
                    MessageBox.Show("Başarılı.");
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
                    comboBox.Text = "";
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

        /// <summary>
        /// TryParse metodu ile girilen değerin sayıya dönüştürülüp dönüştürülemediğini kontrol eder.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Dönüştürme başarılıysa true, değilse false döner.</returns>
        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string foodName = txtFoodName.Text;

            if (lstFoods.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen bir yemek seçiniz");
                return;
            }

            if (!ControlNullOrNot())
            {
                return;
            }
            if (!IsNumeric(txtCalorie.Text) || !IsNumeric(txtGram.Text))
            {
                MessageBox.Show("Lütfen kalori ve gram alanlarına nümerik bir değer giriniz.");
            }
            else
            {
                int userID = _user.ID;
                int categoryID = ((Category)cbCategory.SelectedItem).ID;
                int foodID = (int)lstFoods.SelectedItems[0].Tag;
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
                MessageBox.Show("Başarılı.");
                GetFoods(_user);
                ClearItems(gbxAddFood.Controls);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

                
                int foodID = (int)lstFoods.SelectedItems[0].Tag;
                


                    foodService.Delete(foodID);
                    MessageBox.Show("Successful");
                    GetFoods(_user);
                    ClearItems(gbxAddFood.Controls);
                }
            }
        }
    


