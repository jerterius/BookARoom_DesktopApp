using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.ServiceReferenceUppg2_1;

namespace BookARoom.Views
{
    public partial class UCUppgift2_1 : UserControl
    {
        
        public UCUppgift2_1()
        {
            InitializeComponent();
            cbSelectFile.Text = "Select...";
        }

        

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }

        private void cbSelectFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(WSUppgift2SoapClient client = new WSUppgift2SoapClient())
            {
                textBoxShowFile.Text = client.GetFile();
            }

        }
    }
}
