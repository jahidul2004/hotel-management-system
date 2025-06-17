using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class admin_customers : UserControl
    {
        public admin_customers()
        {
            InitializeComponent();

            displayCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();
        }
        public void displayCustomers()
        {
            customersData cData = new customersData();

            List<customersData> listData = cData.customerListData();

            dataGridView1.DataSource = listData;
        }
    }
}
