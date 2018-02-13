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
using BookARoom.DAL;
using BookARoom.Controllers;
using System.Data.Entity;


namespace BookARoom.Views
{
    public partial class UCNavigator : UserControl
    {
        BookingContext bc = new BookingContext();
        Controller controller = new Controller();

        public UCNavigator()
        {
            InitializeComponent();
        }

        private void tbGuests_Scroll(object addToTable, EventArgs e)
        {
            lblGuests.Text = "Guests: " + tbGuests.Value.ToString();
        }

        private void tbStandard_Scroll(object addToTable, EventArgs e)
        {
            lblStandard.Text = "Rating: " + tbStandard.Value.ToString();

        }
            private void btnSubmit_Click(object addToTable, EventArgs e)
        {
            controller.Add(addToTable, e);
           
            }

        private void UCNavigator_Load(object sender, EventArgs e)
        {
            /* var BookingContext = new BookingContext();
             BindingSource b = new BindingSource();
             b.DataSource = BookingContext.Cities.ToList();
             cbCountry.DataSource = b;

             cbCity.DataSource = b;*/
            cbCountry.DataSource = controller.Retrieve("Country");
            cbCountry.Text = "Choose Country";
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity.DataSource = controller.AllCitiesInCountry(cbCountry.SelectedValue.ToString());
            cbCity.Text = "Choose City";
        }
    }
}
