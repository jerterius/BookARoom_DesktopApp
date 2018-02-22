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

   public List<object> GetEntities(string selectFunction)
    {

        List<object> returnObjects = new List<object>();

        switch (selectFunction)
        {
            case "All Bookings":
                returnObjects = dal.GetAllBookings().Cast<object>().ToList();
                break;
            case "All Cities":
                returnObjects = dal.GetAllCities().Cast<object>().ToList();
                break;
            case "All Customers":
                returnObjects = dal.GetAllCustomers().Cast<object>().ToList();
                break;
            case "All Hotels":
                returnObjects = dal.GetAllHotels().Cast<object>().ToList();
                break;
            case "All Rooms":
                returnObjects = dal.GetAllRooms().Cast<object>().ToList();
                break;
        }

        return returnObjects;
        
    }
    
}