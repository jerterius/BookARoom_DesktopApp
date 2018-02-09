using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.Models;

namespace BookARoom.Views
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        public City SelectedCity
        {
            get
            {
                return (City)comboBox1.SelectedItem;
            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            List<City> cityList = new List<City>();
            cityList.Add(new City());
        }
    }
}
