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
        Controller controller = new Controller();
        BindingSource bindingSource = new BindingSource();

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
            string search = tbSearch.Text;
            string countryName = cbCountry.Text;
            string cityName = cbCity.Text;
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            bindingSource.DataSource = controller.HotelsWithAvailableRooms(cityName);
            hotelDataGridView.DataSource = bindingSource;
            //roomsDataGridView.DataSource = bindingSource;
            //hotelDataGridView.DataSource = controller.GetAllHotels();
            //controller.getAvailableHotels(search, countryName, cityName, fromDate, toDate);

        }

        private void UCNavigator_Load(object sender, EventArgs e)
        {
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
