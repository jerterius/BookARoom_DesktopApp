using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.ServiceReferenceFile;


namespace BookARoom.Views
{
    public partial class UserControlUppgift2 : UserControl
    {
        

        public UserControlUppgift2()
        {
            InitializeComponent();

            cbSelectFile.Text = "Select....";
        }
 

        private void cbSelectFile_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            
            using (WebServiceUppgift2__1SoapClient service = new WebServiceUppgift2__1SoapClient())
            {
                tbxShowFile.Text = service.GetFile();
            }



        }

        private void lbSelectFile_Click(object sender, EventArgs e)
        {

        }
    }
}
