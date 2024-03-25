using CalorieTracking.BLL;
using Microsoft.IdentityModel.Tokens;

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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI_Forms
{
    public partial class UserInfoScreen : Form
    {
        UserDetailService userDetailService;
        UserService userService;
        public UserInfoScreen(User user)
        {
            InitializeComponent();
            userDetailService = new UserDetailService();
            userService = new UserService();
            _user = user;
        }
        User _user;
        private void UserInfoScreen_Load(object sender, EventArgs e)
        {
            LoadScreen();
            if (userDetailService.UserTypeControl(_user.ID))
            {
                btnAdminPanel.Visible = true;
            }
            else
            {
                btnAdminPanel.Visible = false;
            }
        }

        public void LoadScreen()
        {
            txtAd.Text = userDetailService.GetById(_user.ID).Name;
            txtSoyad.Text = userDetailService.GetById(_user.ID).Surname;
            txtDogumTarihi.Text = userDetailService.GetById(_user.ID).BirthDate.ToString();
            txtCinsiyet.Text = userDetailService.GetById(_user.ID).Gender.ToString();
            txtBoy.Text = userDetailService.GetById(_user.ID).Height.ToString();
            txtKilo.Text = userDetailService.GetById(_user.ID).Weight.ToString();
            lblUserType.Text = userService.GetById(_user.ID).UserType.ToString();
        }

        private void btnUpdateHeightWeight_Click(object sender, EventArgs e)
        {
            if (txtGuncelBoy.Text.IsNullOrEmpty() || txtGuncelKilo.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Boy veya kilo boş bırakılamaz!");
                return;
            }

            else
            {
                var updatedUserDetail = userDetailService.GetById(_user.ID);
                updatedUserDetail.Height = Convert.ToInt32(txtGuncelBoy.Text);
                updatedUserDetail.Weight = Convert.ToDouble(txtGuncelKilo.Text);
                if (userDetailService.Update(updatedUserDetail))
                    MessageBox.Show("Boy ve kilo başarıyla güncellendi!");
                else
                {
                    MessageBox.Show("Güncellenirken beklenmedik bir hata oluştu");
                    return;
                }
                txtGuncelBoy.Text = "";
                txtGuncelKilo.Text = "";
                LoadScreen();

            }
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }
    }
}
