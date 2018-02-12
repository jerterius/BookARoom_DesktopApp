using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARoom.DAL;
using BookARoom.Models;
using System.Data;

namespace BookARoom.Controllers
{
    public class Controller
    {
        Dal dal = new Dal();
 
            public int TotalPrice(string bookingNumber)
            {
                return dal.TotalPrice(bookingNumber);
             
            }


        public DataTable AvailableRooms(City city)
        {
           return dal.FindAvailableRooms(city);
        }


        public void Add(object addToTable, EventArgs e)
        {
            dal.Add(addToTable);

        }

                /*try
                {
                    String[] colID = { "Roomtype", "Bed", "Smokefree", "GuestCapacity", "Price", "HotellAdress" };
                    resultList = Dal.FindAvailableRooms();
                    DataTable model = new DataTable();
             

                    model.setRowCount(0);
                    model.setColumnCount(6);
                    model.setColumnIdentifiers(colID);

                    for (String[] entry : resultList)
                    {
                        model.addRow(entry);
                    }
                    return model;

                }
                finally
                {
                    model = null;

                }
           }*/
     }

 }


 
