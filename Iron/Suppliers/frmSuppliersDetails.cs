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
    public partial class frmSuppliersDetails : Form
    {
        public frmSuppliersDetails(int SuppliersID)
        {
            InitializeComponent();
            ctrSuppliersCard1.LoadSuppliersInfo(SuppliersID);
        }
         public frmSuppliersDetails(string NationalN)
        {
            InitializeComponent();
            ctrSuppliersCard1.LoadSuppliersInfo(NationalN);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
