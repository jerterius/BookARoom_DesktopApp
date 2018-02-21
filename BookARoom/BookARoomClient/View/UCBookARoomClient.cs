using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookARoomClient.View
{
    public partial class UCBookARoomClient : UserControl
    {
        public UCBookARoomClient()
        {
            InitializeComponent();
        }

        private void cbSelectEntityTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbSelectEntityTable.Text;

            List<object> entityList = bookARoomWebService1.GetEntities(selectedTable);
        }
    }
}
