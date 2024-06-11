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

namespace Iron.Suppliers
{
    public partial class frmNewPurchaseProcess : Form
    {
        private enum enMode { AddNew = 0 , Update = 1 };
        private enMode _Mode;
        private int _PurchaseID = -1;
        private clsPurchases _Purchase;
        private clsInventory _Inventory;

        public frmNewPurchaseProcess()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmNewPurchaseProcess(int Purchase)
        {
            InitializeComponent();
            _PurchaseID = Purchase;
            _Mode = enMode.Update;
        }

        private  void FillItemsType()
        {
            DataTable _dt = clsCategory.GetAllCategory();

            foreach (DataRow  Row in _dt.Rows)
            {
                cbLisrItems.Items.Add(Row["ItemsType"]);
            }
        }


        void _ResetDefuelValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lbltitle.Text = "New Purchase Process";
                this.Text = "New Purchase Process";
                _Purchase = new clsPurchases();
                tpPurchaseProcess.Enabled = false;
                btnSave.Enabled = false;
                ctrSuppliersCardWithFilter1.FilterFocus();
            }
            else
            {
                lbltitle.Text = "Update Purchase Process";
                this.Text = "Update Purchase Process";
                tpPurchaseProcess.Enabled = true;
                btnSave.Enabled = true;

            }

            FillItemsType();
            txtDateOfPurchase.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtThickness.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtWeight.Text= string.Empty;
            txtWidth.Text = string.Empty;
            nudCounter.Value = 0;
        }

        private void _LoadData()
        {
            _Purchase = clsPurchases.FindByID(_PurchaseID);
            ctrSuppliersCardWithFilter1.FilterEnabled = false;
            cbLisrItems.Enabled = false;
            if (_Purchase == null)
            {
                MessageBox.Show("There is no purchase process with this ID [" + _PurchaseID.ToString() + "]");
                return;
            }
            cbLisrItems.SelectedIndex = cbLisrItems.FindString(clsCategory.Find(_Purchase.CategoryID).ItemsType);
            txtDateOfPurchase.Text = _Purchase.DateOfPurchase.ToString();
            txtPrice.Text = _Purchase.Price.ToString();
            txtThickness.Text = _Purchase.Thickness.ToString();
            txtTotalAmount.Text = (_Purchase.Quantity * _Purchase.Price).ToString();
            txtWeight.Text = _Purchase.Weight.ToString();
            txtWidth.Text = _Purchase.Width.ToString();
            nudCounter.Value = _Purchase.Quantity;
            ctrSuppliersCardWithFilter1.LoadSuppliersInfo(_Purchase.SupplierID);
        }
        private void frmNewPurchaseProcess_Load(object sender, EventArgs e)
        {
            _ResetDefuelValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpPurchaseProcess.Enabled = true;
                tcPurchass.SelectedTab = tcPurchass.TabPages["tpPurchaseProcess"];
                return;
            }

            if (ctrSuppliersCardWithFilter1.SuppliersID != -1)
            {
                btnSave.Enabled = true;
                tpPurchaseProcess.Enabled = true;
                tcPurchass.SelectedTab = tcPurchass.TabPages["tpPurchaseProcess"];
            }
            else
            {
                MessageBox.Show("Can't Enabled The Purchase Process Without Suppliers");
            }
        }




        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void TextData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Temp = (Guna.UI2.WinForms.Guna2TextBox)sender;
            

            
            if (string.IsNullOrWhiteSpace(Temp.Text.Trim()))
            {
                e.Cancel = true; 
                errorProvider1.SetError(Temp, "This field is required"); 
            }
            else
            {
                errorProvider1.SetError(Temp, ""); 
            }
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Put The Read Icon To Read Error");
                return;
            }

             
        }
    }
}
