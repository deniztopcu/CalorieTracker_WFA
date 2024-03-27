using CalorieTracking.BLL;
using CaloriTracker.DAL.Repositories.Concrete;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Forms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            userService = new UserService();

        }
        UserService userService;

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadUsersList();
        }
        
        public void LoadUsersList()
        {
            lvUsers.Items.Clear();
            List<User> users = userService.GetUsers();
            foreach (var user in users)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = user.ID.ToString();
                lvi.SubItems.Add(user.Email.ToString());
                lvi.SubItems.Add(user.Password.ToString());
                lvi.Tag = user.ID;
                lvUsers.Items.Add(lvi);
            }
        }

        User selectedUser;
        private void lvUsers_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 1)
            {
                selectedUser = userService.GetById((int)(lvUsers.SelectedItems[0].Tag));
                txtEmail.Text = selectedUser.Email;
                txtSifre.Text = selectedUser.Password;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            userService.Delete(selectedUser.ID);
            lvUsers.SelectedItems[0].Remove();
            MessageBox.Show("User is deleted!");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            selectedUser.Email = txtEmail.Text;
            string password = sha256(txtSifre.Text);
            selectedUser.Password = password;
            userService.Update(selectedUser);
            MessageBox.Show("User is updated!");
        }

        private string sha256(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
