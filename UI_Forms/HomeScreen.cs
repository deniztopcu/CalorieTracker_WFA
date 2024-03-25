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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            foodService = new FoodService();

        }
        FoodService foodService;

        private void btnVegetables_Click(object sender, EventArgs e)
        {

            List<Food> vegetables = foodService.GetFoodsByCategoryID(5);
            ListViewDoldur(vegetables);
        }

        private void ListViewDoldur(List<Food> foods)
        {
            lvYemekleriListele.Items.Clear();
            foreach (Food food in foods)
            {
                string foodInfo = food.Name;

                ListViewItem lvi = new(foodInfo);
                lvi.Tag = food.ID;

                lvYemekleriListele.Items.Add(lvi);
            }
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {

            List<Food> fruit = foodService.GetFoodsByCategoryID(11);
            ListViewDoldur(fruit);
        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {

        }
    }
}
