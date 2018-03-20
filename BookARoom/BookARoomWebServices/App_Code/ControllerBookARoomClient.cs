using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ControllerBookARoomClient
/// </summary>
public class ControllerBookARoomClient
{
    DalBookARoomClient dal = new DalBookARoomClient();
    public ControllerBookARoomClient()
    {

    }

   /* public List<Object> GetEntities(string selectFunction)
    {

        List<Object> returnObjects;
        
        switch (selectFunction)
        {
            case "All Bookings":
                returnObjects = dal.GetAllBookings().
                break;
            case "All Cities":
                dal.GetAllCities();
                break;
            case "All Customers":
                dal.GetAllCustomers();
                break;
            case "All Hotels":
                dal.GetAllHotels();
                break;
            case "All Rooms":
                dal.GetAllRooms();
                break;
        }

        return returnObjects;
        
    }
    */
}