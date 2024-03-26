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
using UI_Forms;

namespace UI_Forms
{
    public partial class HistoryScreen : Form
    {
        public HistoryScreen(User user)
        {
            InitializeComponent();
            _userMealDetail = new UserMealDetail();
            _user = user;
        }
        UserMealDetail _userMealDetail;
        User _user;
    }
}


