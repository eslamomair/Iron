﻿using System;
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
    public partial class frmCustomerDetails : Form
    {
        public frmCustomerDetails(int CustomerID)
        {
            InitializeComponent();
            ctrCustomerCard1.LoadCustomerInfo(CustomerID);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
