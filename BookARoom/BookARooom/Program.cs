using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.Views;
using BookARoom.Models;
using BookARoom.DAL;
using System.Data.Entity;

namespace BookARoom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            Database.SetInitializer<BookingContext>(null);
        }
    }
}
