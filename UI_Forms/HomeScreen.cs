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
        public HomeScreen(User user)
        {
            InitializeComponent();
            userMealDetailService = new UserMealDetailService();
            foodService = new FoodService();
            mealService = new MealService();
            _user = user;
        }

        UserMealDetailService userMealDetailService;
        FoodService foodService;
        MealService mealService;
        User _user;

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


        private void HomeScreen_Load(object sender, EventArgs e)
        {
            var meals = mealService.GetAllMeals();

            foreach (var meal in meals)
            {
                cmbOgunler.Items.Add(meal);
            }
        }

        // Kategorilere göre yemeklerin listelenmesi
        private void btnVegetables_Click(object sender, EventArgs e)
        {
            List<Food> vegetables = foodService.GetFoodsByCategoryID(5);
            ListViewDoldur(vegetables);
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {

            List<Food> fruits = foodService.GetFoodsByCategoryID(11);
            ListViewDoldur(fruits);
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

        // Öğün ekleme işlemleri
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
            var userMealDetail = new UserMealDetail();
            userMealDetail.UserID = _user.ID;
            var foodId = ((int)lvYemekleriListele.SelectedItems[0].Tag);
            var selectedFood = foodService.GetById(foodId);
            userMealDetail.FoodID = selectedFood.ID;

            var selectedMeal = (Meal)cmbOgunler.SelectedItem;

            userMealDetail.MealID = selectedMeal.ID;
            userMealDetail.FoodCount = (int)nudGram.Value;

            double calorie = selectedFood.Calorie;
            double portionGram = selectedFood.PortionGram;

            double finalCalorie;
            if (cmbOgunler.Text == "Gram")
            {
                finalCalorie = calorie / 100 * userMealDetail.FoodCount;
                userMealDetail.Food.PortionName = PortionNames.Gram;
            }
            else
            {
                finalCalorie = calorie / 100 * userMealDetail.FoodCount * portionGram;
            }

            userMealDetail.TotalCalorie = finalCalorie;
            if (userMealDetailService.Add(userMealDetail))
                MessageBox.Show("Ogun datalarına eklendi");
            else
                MessageBox.Show("Ogun eklenemedi");



            ListViewOgunListesiDoldur(userMealDetail);

        }

        private void ListViewOgunListesiDoldur(UserMealDetail mealDetail)
        {
            var food = foodService.GetById(mealDetail.FoodID);
            var meal = mealService.GetById(mealDetail.MealID);
            string[] mealDetailInfo = { food.Name, food.PortionName.ToString(), food.Calorie.ToString(), meal.MealType.ToString() };

            ListViewItem lvi = new(mealDetailInfo);
            lvi.Tag = mealDetail.ID;

            lvOgunListesi.Items.Add(lvi);

        }

        private void btnOgunlerimiKaydet_Click(object sender, EventArgs e)
        {
            var list = lvOgunListesi.Items;

            foreach (ListViewItem item in list)
            {
                int userMealDetailID = (int)item.Tag;
                UserMealDetail userMealDetail = userMealDetailService.GetById(userMealDetailID);
                userMealDetailService.Update(userMealDetail, Status.Active);
            }

            MessageBox.Show("Öğünleriniz kaydedildi.");
        }

        private void btnOgunlerimiSil_Click(object sender, EventArgs e)
        {
            userMealDetailService.Delete((int)lvOgunListesi.SelectedItems[0].Tag);
            lvOgunListesi.SelectedItems[0].Remove();

            MessageBox.Show("Öğünleriniz silindi.");
        }
    }
}
