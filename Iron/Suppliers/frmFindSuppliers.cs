using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.Suppliers
{
    public partial class frmFindSuppliers : Form
    {
        public delegate void DataBackEventHandler(object sender, int SuppliersID);
        public event DataBackEventHandler DataBack;

        public frmFindSuppliers()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke  (sender,ctrSuppliersCardWithFilter1.SuppliersID);
            this.Close();
        }
    }
}
