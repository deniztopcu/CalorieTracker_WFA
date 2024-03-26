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
using UI_Forms;

namespace UI_Forms
{
    public partial class HistoryScreen : Form
    {
        public HistoryScreen(User user)
        {
            InitializeComponent();
            _userMealDetailService = new UserMealDetailService();
            _user = user;
            foodService= new FoodService();
            mealService = new MealService();
            categoryService = new CategoryService();
        }
        UserMealDetailService _userMealDetailService;
        User _user;
        FoodService foodService;
        MealService mealService;
        CategoryService categoryService;

        //UserMealDetail userMealDetail1;
        private void HistoryScreen_Load(object sender, EventArgs e)
        {
            int userID = _user.ID;
            //userMealDetail1 = new UserMealDetail();
            List<UserMealDetail> UML = _userMealDetailService.GetUserMealHistoryByUserID(userID);
            ListViewDoldur(UML);

        }

        private void ListViewDoldur2()
        {
            lvMeals.Items.GroupBy
        }

        private void ListViewDoldur(List<UserMealDetail> userMealDetails)
        {
            lvMeals.Items.Clear();
            foreach (UserMealDetail userMealDetail in userMealDetails)
            {
                if (userMealDetail != null)
                {
                    var food= foodService.GetById(userMealDetail.FoodID);
                    var meal = mealService.GetById(userMealDetail.MealID);
                    var categoryID = food.CategoryID;
                    var category = categoryService.GetById(categoryID);
                    double calorie = food.Calorie;
                    double portionGram = food.PortionGram;
                    PortionNames portionName = food.PortionName;

                    double finalCalorie;
                    if (portionName == PortionNames.Gram)
                    {
                        finalCalorie = calorie / 100 * userMealDetail.FoodCount;
                        food.PortionName = PortionNames.Gram;
                    }
                    else
                    {
                        finalCalorie = calorie / 100 * userMealDetail.FoodCount * portionGram;
                    }

                    string[] userMealDetailInfo = { userMealDetail.ID.ToString(), food.Name, category.CategoryName, calorie.ToString(), userMealDetail.FoodCount.ToString(), finalCalorie.ToString(), portionName.ToString(), meal.MealType.ToString() };

                    ListViewItem lvi = new(userMealDetailInfo);
                    lvi.Tag = userMealDetail.CreationDate.Date;

                    lvMeals.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("Null");
                }
            }
        }
    }
}


