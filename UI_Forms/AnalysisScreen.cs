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
    public partial class AnalizScreen : Form
    {
        User user;
        public AnalizScreen(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        UserMealDetailService detailservice;

        private void AnalizScreen_Load(object sender, EventArgs e)
        {
            LoadCompareYourself();
            LoadCompareMeals();
            LoadWhatDidIEat();
        }

        public void LoadCompareYourself()
        {
            lwHaftalikAylikDurum.Items.Clear();
            int CompareDay = 7;
            if (rbHaftalik.Checked == true) CompareDay = 30;
            detailservice = new UserMealDetailService();
            foreach (Category category in detailservice.GetAllCategories())
            {
                string[] arr = { category.CategoryName, detailservice.TotalConsumptionOfCategory(category.ID, CompareDay).ToString(), detailservice.ConsumptionOfCategoryByUser(user, category, CompareDay).ToString(), detailservice.TotalCalorieOfCategory(category.ID, CompareDay).ToString(), detailservice.TotalCalorieOfCategoryByUser(category.ID, user, CompareDay).ToString() };
                ListViewItem lvi = new ListViewItem(arr);
                lvi.Tag = category;
                lwOgunlereGoreKarsilastir.Items.Add(lvi);
            }
        }

        public void LoadCompareMeals()
        {
            lwOgunlereGoreKarsilastir.Items.Clear();
            int CompareDay = 7;
            if (rbAylik.Checked == true) CompareDay = 30;
            detailservice = new UserMealDetailService();
            foreach (Meal meal in detailservice.GetAllMeals(user))
            {
                string[] arr = new string[5];
                arr[0] = meal.MealType.ToString();
                arr[1] = detailservice.GetMealConsumptionsOfAllUsers(meal, CompareDay);
                arr[2] = detailservice.GetMealConsumptionsOfAllUsers(meal, user, CompareDay);
                arr[3] = detailservice.GetMealCaloriesOfAllUsers(meal, CompareDay);
                arr[4] = detailservice.GetMealCaloriesOfAllUsers(meal, user, CompareDay);
                ListViewItem lvi = new ListViewItem(arr);
                lvi.Tag = meal;
                lwOgunlereGoreKarsilastir.Items.Add(lvi);

            }
        }

        FoodService foodService;
        public void LoadWhatDidIEat()
        {
            lwYenilenOgunler.Items.Clear();
            detailservice = new UserMealDetailService();
            int counter = 0;
            foreach (Meal meal in detailservice.GetAllMeals(user))
            {
                string[] arr = new string[4];
                arr[0] = string.Empty;
                arr[1] = meal.MealType.ToString();
                arr[2] = detailservice.GetCountOfUsersSpecificMeal(meal, user).ToString();
                arr[3] = detailservice.GetTotalCalorieOfSpecificMealOfUser(meal, user);
                ListViewItem lvi = new ListViewItem(arr);
                lvi.Font = new Font(Font, FontStyle.Bold);
                lwYenilenOgunler.Items.Add(lvi);
                lvi.Tag = meal;
                counter = 0;
                foreach (UserMealDetail item in detailservice.GetUserMealHistoryOfMeal(meal.ID))
                {
                    Food food= new Food();
                    foodService = new FoodService();
                    food = foodService.GetFoodByID(item.FoodID);
                    counter++;
                    string[] arr2 = new string[4];
                    arr2[0] = counter.ToString();
                    arr2[1] = food.Name;
                    arr2[2] = item.FoodCount.ToString();
                    arr2[3] = (food.Calorie * item.FoodCount).ToString();
                    ListViewItem lvi2 = new ListViewItem(arr2);
                    lwYenilenOgunler.Items.Add(lvi2);
                    lvi2.Tag = item;
                }
            }
        }

        private void rbHaftalik_CheckedChanged(object sender, EventArgs e)
        {
            LoadCompareYourself();
            LoadCompareMeals();
        }

        private void rbAylik_CheckedChanged(object sender, EventArgs e)
        {
            LoadCompareYourself();
            LoadCompareMeals();
        }
    }
}
