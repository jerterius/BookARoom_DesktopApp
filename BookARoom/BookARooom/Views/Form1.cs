using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.DAL;
using BookARoom.Models;
using System.Data.Entity;

namespace BookARoom.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ucNavigator1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        
    }
}
