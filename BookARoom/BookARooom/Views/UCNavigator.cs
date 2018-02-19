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
        private Controller controller = new Controller();
       
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
            string search = tbxSearch.Text;
            string countryName = cbCountry.Text;
            string cityName = cbCity.Text;
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            string standard = tbStandard.Value.ToString();
            int guests = tbGuests.Value;
            bool smokeFree = clbRoomStandard.GetItemCheckState(0) == CheckState.Checked;

            /* //Detta är exempelkod på hur vi kan hämta data och binda våra tabeller
             hotelBindingSource.DataSource = controller.TestGetData();
             hotelBindingSource.DataMember = "Hotels";

             roomsBindingSource.DataSource = hotelBindingSource;
             roomsBindingSource.DataMember = "HotelsRooms";*/

            controller.HotelsWithAvailableRooms(search, countryName, cityName, fromDate, toDate, standard, guests, smokeFree);

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
            //hotelDataGridView.DataSource = controller.GetAllHotels();*/

        }

        private void UCNavigator_Load(object sender, EventArgs e)
        {
            
            cbCountry.DataSource = controller.GetAllCountries();
            cbCountry.Text = "Choose Country";

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity.DataSource = controller.AllCitiesInCountry(cbCountry.SelectedValue.ToString());
            cbCity.Text = "Choose City";
        }

        private void hotelDataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }

        string roomNumber;
        string adress;
        string cEmail;

        private void roomsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (roomsDataGridView.Columns[e.ColumnIndex].Name == "Booking")
            {
                roomNumber = ((DataGridView)sender).Rows[e.RowIndex].Cells["roomNumberDataGridViewTextBoxColumn"].Value.ToString();
                adress = ((DataGridView)sender).Rows[e.RowIndex].Cells["adressDataGridViewTextBoxColumn"].Value.ToString();

                for (var date = dtpFromDate.Value.Date; date <= dtpToDate.Value.Date; date = date.AddDays(1))
                {
                    controller.AddBooking(cEmail, adress, roomNumber, 0, date);
                }
               

            }
        }
        public void GetCustomerData(object sender, EventArgs e)
        {
            cEmail = (sender as TextBox).Text;
    
        }

        public void LoadCustomerData(object sender, EventArgs e)
        {
            UCLogin ucLogin = sender as UCLogin;

        }


    }
}
