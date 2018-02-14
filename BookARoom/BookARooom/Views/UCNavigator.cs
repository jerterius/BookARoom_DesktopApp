﻿using System;
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

            //Detta är exempelkod på hur vi kan hämta data och binda våra tabeller
            hotelBindingSource.DataSource = controller.TestGetData();
            hotelBindingSource.DataMember = "Hotels";
            
            roomsBindingSource.DataSource = hotelBindingSource;
            roomsBindingSource.DataMember = "HotelsRooms";

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "SELECT";
            col.Name = "Booking";
            roomsDataGridView.Columns.Add(col);
            

            /*
            hotelBindingSource.DataSource = controller.HotelsWithAvailableRooms(cityName);
            hotelDataGridView.DataSource = hotelBindingSource;
            roomsDataGridView.DataSource = hotelBindingSource;
            //roomsDataGridView.DataSource = bindingSource;
            //hotelDataGridView.DataSource = controller.GetAllHotels();
            //controller.getAvailableHotels(search, countryName, cityName, fromDate, toDate);*/

        }

        private void UCNavigator_Load(object sender, EventArgs e)
        {
            
            cbCountry.DataSource = controller.Retrieve("Country");
            cbCountry.Text = "Choose Country";

            /*//Detta är exempelkod på hur vi kan hämta data och binda våra tabeller
            hotelBindingSource.DataSource = controller.TestGetData();
            hotelBindingSource.DataMember = "Hotels";

            roomsBindingSource.DataSource = hotelBindingSource;
            roomsBindingSource.DataMember = "HotelsRooms";*/

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity.DataSource = controller.AllCitiesInCountry(cbCountry.SelectedValue.ToString());
            cbCity.Text = "Choose City";
        }

        private void hotelDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void roomsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (roomsDataGridView.Columns[e.ColumnIndex].Name == "Booking")
            {
                tbSearch.Text = "Vad händer?";
            }
        }
    }
}
