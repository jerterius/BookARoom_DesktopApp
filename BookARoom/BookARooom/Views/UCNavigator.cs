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
using BookARoom.Utilities;


namespace BookARoom.Views
{
    public partial class UCNavigator : UserControl
    {
        public delegate void UpdateBookings(object sender, EventArgs e);
        public UpdateBookings updateBookings;

        private Controller controller = new Controller();
        public Customer Customer { get; set; }

        public UCNavigator()
        {

            InitializeComponent();
        }


        private void TbGuests_Scroll(object addToTable, EventArgs e)
        {
            try
            {
                lblGuests.Text = "Guests: " + tbGuests.Value.ToString();

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }


        }

        private void TbStandard_Scroll(object addToTable, EventArgs e)
        {
            try
            {
                lblStandard.Text = "Rating: " + tbStandard.Value.ToString();

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }


        }
        private void BtnSubmit_Click(object addToTable, EventArgs e)
        {
            try
            {

                string search = tbxSearch.Text;
                string countryName = cbCountry.Text;
                string cityName = cbCity.Text;
                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date;
                string standard = tbStandard.Value.ToString();
                int guests = tbGuests.Value;
                bool smokeFree = clbRoomStandard.GetItemCheckState(0) == CheckState.Checked;

                List<Hotel> hotels = controller.HotelFilter(search, countryName, cityName, fromDate, toDate, standard, guests, smokeFree);
                hotelBindingSource.DataSource = hotels;

                roomsBindingSource.DataSource = hotelBindingSource;
                roomsBindingSource.DataMember = "Rooms";

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }

        private void UCNavigator_Load(object sender, EventArgs e)
        {
            try
            {
                cbCountry.DataSource = controller.GetAllCountries();
                cbCountry.Text = "Choose Country";

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }


        }

        private void CbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbCity.DataSource = controller.AllCitiesInCountry(cbCountry.SelectedValue.ToString());
                cbCity.Text = "Choose City";

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }


        }

        private void RoomsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Customer != null)
                {

                    if (roomsDataGridView.Columns[e.ColumnIndex].Name == "Booking")
                    {
                        string roomNumber = ((DataGridView)sender).Rows[e.RowIndex].Cells["roomNumberDataGridViewTextBoxColumn"].Value.ToString();
                        string adress = ((DataGridView)sender).Rows[e.RowIndex].Cells["adressDataGridViewTextBoxColumn"].Value.ToString();

                        for (var date = dtpFromDate.Value.Date; date <= dtpToDate.Value.Date; date = date.AddDays(1))
                        {
                            controller.AddBooking(Customer.CEmail, adress, roomNumber, 0, date);
                        }
                        btnSubmit.PerformClick();

                        updateBookings?.Invoke(null, EventArgs.Empty);

                        lblResponse.Text = "Booking was added.";
                    }
                }
                else
                {
                    lblResponse.Text = "Booking not allowed. Please login.";
                }
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }

        public void LoadUser(Customer c, EventArgs e)
        {

            try
            {
                Customer = c;

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }



        }

        private void DtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFromDate.Value > dtpToDate.Value)
                {
                    dtpFromDate.Value = dtpToDate.Value;
                }

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }

        private void DtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFromDate.Value > dtpToDate.Value)
                {
                    dtpToDate.Value = dtpFromDate.Value;
                }

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }


        }

    }
}
