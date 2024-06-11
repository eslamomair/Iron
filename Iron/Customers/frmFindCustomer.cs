using Iron.Customers.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.Customers
{
    public partial class frmFindCustomer : Form
    {
        ctrCustomerCardWithFilter filter;
        public delegate void DataBackEventHandler(object sender, int CustomerID);
        public event DataBackEventHandler DataBack;
        public frmFindCustomer()
        {
            InitializeComponent();
            Controls.Add(filter);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this,ctrCustomerCardWithFilter2.CustomerID);
            this.Close();
        }
    }
}
