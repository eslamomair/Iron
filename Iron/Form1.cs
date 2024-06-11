using Iron.Customers;
using Iron.Global_Classes;
using Iron.Login;
using Iron.People;
using Iron.Purchase_Process;
using Iron.Selling_Process;
using Iron.SubCategories;
using Iron.Suppliers;
using Iron.Users;
using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron
{
    public partial class frmMenu : Form
    {
        int CustomerID = -1;
        int Suppliers_PersonID = -1;
        frmLogin frmLogin;
        public frmMenu(frmLogin lo)
        {
            InitializeComponent();
            frmLogin = lo;
        }

        private void ReceivePersonID(object sender , int PersonID)
        {
            CustomerID = PersonID;

        }

        private void tsmAddNewCustomer_Click(object sender, EventArgs e)
        {
             frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += ReceivePersonID;
            frm.ShowDialog();
            if (CustomerID > 0 )
            {
                _SaveCustomer();
            }
            else
            {
                MessageBox.Show("Data Fail");
            }
        }
        void _SaveCustomer()
        {
            clsCustomers Customers = new clsCustomers();
            Customers.PersonID =  CustomerID;
            Customers.CreatedByUserID = 1;
            if (Customers.Save())
            {
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Data Fail");
            }
        }

        private void tsmUpdateCustomer_Click(object sender, EventArgs e)
        {
            Form frm = new frmFindPerson();
            frm.ShowDialog();

        }

        private void tsmFindCustomer_Click(object sender, EventArgs e)
        {
            Form form = new frmFindCustomer();
            form.ShowDialog();
        }

        private void tsmShowAllCustomer_Click(object sender, EventArgs e)
        {
            Form form = new frmListCustomer();
            form.ShowDialog();
        }

        private void tsmShowAllSuppliers_Click(object sender, EventArgs e)
        {
            Form form = new frmListSuppliers();
            form.ShowDialog();
        }

        private void tsmFindSuppliers_Click(object sender, EventArgs e)
        {
            Form form = new frmFindSuppliers();
            form.ShowDialog();
        }

        private void tsmAddNewSuppliers_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += DataBackSuppliersID;
            frm.ShowDialog();
            _SaveDataSuppliers();
        }

        private void DataBackSuppliersID(object sender, int Suppliers)
        {
           Suppliers_PersonID = Suppliers;
        }

        private void _SaveDataSuppliers()
        {
            if (Suppliers_PersonID > 0)
            {
                clsSuppliers suppliers = new clsSuppliers();
                suppliers.PersonID = Suppliers_PersonID;
                suppliers.CreatedByUserID = clsGlobalUser.CurrentUser.ID; 
                if (suppliers.Save())
                {
                    MessageBox.Show("Data Save");
                }
                else
                    MessageBox.Show("Data Not  Saved");
            }
        }

        private void tsmLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            clsGlobalUser.CurrentUser = null;
            frmLogin.Show();
        }

        private void tsmAddNewSubCategory_Click(object sender, EventArgs e)
        {
           Form form = new frmAddUpdateSubCategories();
            form.ShowDialog();

        }

        private void tsmListOfItems_Click(object sender, EventArgs e)
        {
            Form frm  = new frmListOfItems();
            frm.ShowDialog();
        }

        private void tsmNewPurchase_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePurchase();
            frm.ShowDialog();
        }

        private void tsmShowAllPurchase_Click(object sender, EventArgs e)
        {
            Form frm = new frmPurchaseProcessList();
            frm.ShowDialog();
        }

        private void tsmNewSale_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdateSellingProcess();
            form.ShowDialog();
        }

        private void tsmViewAllSailing_Click(object sender, EventArgs e)
        {
            Form form = new frmListAllSailingProcess();
            form.ShowDialog();
            Refresh();
        }

        private void tsmChanindPassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(clsGlobalUser.CurrentUser.ID);
            frm.ShowDialog();
        }

        private void tsmAddNewUsers_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
        }
    }
}
