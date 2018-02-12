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


namespace BookARoom.Views
{
    public partial class UCNavigator : UserControl
    {
        Controller controller = new Controller();

        public UCNavigator()
        {
            InitializeComponent();
        }

        private void button2_Click(object addToTable, EventArgs e)
        {
            controller.Add(addToTable, e);
           

                // Display all Blogs from the database 
                var query = from b in db.Cities
                            orderby b.CityName
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.CityName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }


        /* public City SelectedCity
         {
             get
             {
                 return (City)cbCity.SelectedItem;
             }
         }
         private void UserControl1_Load(object sender, EventArgs e)
         {
             List<City> cityList = new List<City>();
             cityList.Add(new City("Lund", "Sweden"));
             cityList.Add(new City("Malmö", "Sweden"));
             cityList.Add(new City("Eslöv", "Sweden"));
             cityList.Add(new City("Helsingborg", "Sweden"));
             cbCity.DataSource = cityList;
             cbCity.ValueMember = "ID";
             cbCity.DisplayMember = "Cityname";
         }*/
    }
}