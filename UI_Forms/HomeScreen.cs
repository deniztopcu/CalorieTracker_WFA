using CalorieTracking.BLL;
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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();

            foodService = new FoodService();
            mealService = new MealService();
        }
        FoodService foodService;
        MealService mealService;

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

            List<Food> fruits = foodService.GetFoodsByCategoryID(11);
            ListViewDoldur(fruits);
        }



        private void HomeScreen_Load(object sender, EventArgs e)
        {

            var meals = mealService.GetAllMeals();

            foreach (var meal in meals)
            {
                cmbOgunler.Items.Add(meal);
            }



        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            List<Food> softDrinks = foodService.GetFoodsByCategoryID(2);
            ListViewDoldur(softDrinks);
        }

        private void btnAlkol_Click(object sender, EventArgs e)
        {
            List<Food> alcoholicBeverages = foodService.GetFoodsByCategoryID(1);
            ListViewDoldur(alcoholicBeverages);
        }



        private void btnFastFood_Click(object sender, EventArgs e)
        {
            List<Food> fastFoods = foodService.GetFoodsByCategoryID(9);
            ListViewDoldur(fastFoods);
        }

        private void btnCookies_Click(object sender, EventArgs e)
        {
            List<Food> cookies = foodService.GetFoodsByCategoryID(3);
            ListViewDoldur(cookies);
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            List<Food> desserts = foodService.GetFoodsByCategoryID(8);
            ListViewDoldur(desserts);
        }

        private void btnLegumes_Click(object sender, EventArgs e)
        {
            List<Food> legumes = foodService.GetFoodsByCategoryID(4);
            ListViewDoldur(legumes);
        }

        private void btnMilkProducts_Click(object sender, EventArgs e)
        {
            List<Food> milkProducts = foodService.GetFoodsByCategoryID(14);
            ListViewDoldur(milkProducts);
        }

        private void btnSeaProducts_Click(object sender, EventArgs e)
        {
            List<Food> seaProducts = foodService.GetFoodsByCategoryID(7);
            ListViewDoldur(seaProducts);
        }

        private void btnMeatProducts_Click(object sender, EventArgs e)
        {
            List<Food> meatProducts = foodService.GetFoodsByCategoryID(10);
            ListViewDoldur(meatProducts);
        }

        private void btnGrainProducts_Click(object sender, EventArgs e)
        {
            List<Food> grainProducts = foodService.GetFoodsByCategoryID(13);
            ListViewDoldur(grainProducts);
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            List<Food> soups = foodService.GetFoodsByCategoryID(6);
            ListViewDoldur(soups);
        }

        private void btnMultigrainCereals_Click(object sender, EventArgs e)
        {
            List<Food> multigrainCereals = foodService.GetFoodsByCategoryID(15);
            ListViewDoldur(multigrainCereals);
        }

        private void btnMainDishes_Click(object sender, EventArgs e)
        {
            List<Food> mainDishes = foodService.GetFoodsByCategoryID(12);
            ListViewDoldur(mainDishes);
        }

        private void lvYemekleriListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPorsiyon.Text = "";
            cmbPorsiyon.Items.Clear();
            if (lvYemekleriListele.SelectedItems.Count > 0)
            {
                cmbPorsiyon.Items.Add(foodService.GetById(((int)lvYemekleriListele.SelectedItems[0].Tag)).PortionName.ToString());
                cmbPorsiyon.Items.Add("Gram");
            }

        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {

            string yemekIsmi = lvYemekleriListele.SelectedItems[0].Name;
            string pn = cmbPorsiyon.Text;
            string ogun=cmbOgunler.Text;
            double calorie = foodService.GetById(((int)lvYemekleriListele.SelectedItems[0].Tag)).Calorie;
            double pg = foodService.GetById(((int)lvYemekleriListele.SelectedItems[0].Tag)).PortionGram;

            double finalCalorie;
            if (cmbOgunler.Text == "Gram")
            {
                finalCalorie = calorie/100 * Convert.ToDouble(nudGram.Value);
            }
            else
            {
                finalCalorie = calorie/100 * Convert.ToDouble(nudGram.Value) * pg;
            }


          
        }

     
    }
}
