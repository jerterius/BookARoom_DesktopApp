using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void btnSelect_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("Text_File.Text");
        }

        private void cbFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
