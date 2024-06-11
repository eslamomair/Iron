using Iron.Global_Classes;
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

namespace Iron.Purchase_Process
{
    public partial class frmAddUpdatePurchase : Form
    {
       
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _PurchaseID = -1;
        private clsPurchases _Purchase;
        private clsNewInventory _Inventory;
        clsSubCategories SubCat;
        public frmAddUpdatePurchase()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdatePurchase(int Purchase)
        {
            InitializeComponent();
            _PurchaseID = Purchase;
            _Mode = enMode.Update;
        }

        private void FillTextDataWithSubCategorySelected()
        {
            SubCat =  clsSubCategories.FindByType(cbSubCategory.Text);
           // clsSubCategories    Sub =  clsSubCategories.FindByType(cbSubCategory.Text);
            txtDateOfPurchase.Text = DateTime.Now.ToString();
            txtPrice.Text = SubCat.Price.ToString();
            txtThickness.Text = SubCat.Thickness.ToString();
            txtTotalAmount.Text = (nudCounter.Value * SubCat.Price).ToString();
            txtWeight.Text = SubCat.Weight.ToString();
            txtWidth.Text = SubCat.Width.ToString();
        }

        private void FillSubItemsType(int CategoryID)
        {
            DataTable _dt = clsSubCategories.GetAllRowsByCategoryID(CategoryID);
            foreach (DataRow  item in _dt.Rows)
            {
                cbSubCategory.Items.Add(item["Type"]);
            }

           
        }

        private void FillItemsType()
        {
            DataTable _dt = clsCategory.GetAllCategory();

            foreach (DataRow Row in _dt.Rows)
            {
                cbLisItems.Items.Add(Row["ItemsType"]);
            }
        }


        void _ResetDefuelValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lbltitle.Text = "New Purchase Process";
                this.Text = "New Purchase Process";
                _Purchase = new clsPurchases();
                _Inventory = new clsNewInventory();
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
            txtWeight.Text = string.Empty;
            txtWidth.Text = string.Empty;
            nudCounter.Value = 0;
        }

        private void _LoadData()
        {
            _Purchase = clsPurchases.FindByID(_PurchaseID);
            _Inventory = clsNewInventory.FindByIDInventory(_Purchase.NewInventoryID);
            ctrSuppliersCardWithFilter1.FilterEnabled = false;
            cbLisItems.Enabled = false;
            cbSubCategory.Enabled = false;
            if (_Purchase == null)
            {
                MessageBox.Show("There is no purchase process with this ID [" + _PurchaseID.ToString() + "]");
                return;
            }
            cbLisItems.SelectedIndex = cbLisItems.FindString(clsCategory.Find(_Purchase.CategoryID).ItemsType);
            cbSubCategory.SelectedIndex = cbSubCategory.FindString(clsSubCategories.FindByID(_Purchase.SubCategoriesID).Type);
            txtDateOfPurchase.Text = _Purchase.DateOfPurchase.ToString();
            txtPrice.Text = _Purchase.Price.ToString();
            txtThickness.Text = _Purchase.Thickness.ToString();
            txtTotalAmount.Text = (_Purchase.Quantity * _Purchase.Price).ToString();
            txtWeight.Text = _Purchase.Weight.ToString();
            txtWidth.Text = _Purchase.Width.ToString();
            nudCounter.Value = _Purchase.Quantity;
            ctrSuppliersCardWithFilter1.LoadSuppliersInfo(_Purchase.SupplierID);
            
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
                errorProvider1.SetError(Temp, "هذا الحقل مطلوب");
            }
            else
            {
                errorProvider1.SetError(Temp, "");
            }
        }

     


        private void btnNext_Click_1(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdatePurchase_Load(object sender, EventArgs e)
        {
            _ResetDefuelValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void cbLisItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubCategory.Items.Clear();
            FillSubItemsType(clsCategory.Find(cbLisItems.Text).CategoryID);
            cbSubCategory.SelectedIndex = 0;
        }

        private void cbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTextDataWithSubCategorySelected();
        }

        private void nudCounter_ValueChanged(object sender, EventArgs e)
        {
            //repair
            txtTotalAmount.Text = (Convert.ToDecimal(txtPrice.Text) * nudCounter.Value).ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Put The Read Icon To Read Error");
                return;
            }
            //repair
           // clsSubCategories SubCat = clsSubCategories.FindByType(cbSubCategory.Text);

            _Inventory.SubCategoryID = SubCat.ID;
            _Inventory.Quantity = nudCounter.Value;
            _Inventory.Price = SubCat.Price * nudCounter.Value;
            _Inventory.UnitPrice = SubCat.Price;
            _Inventory.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
            if (_Inventory.Save())
            {
                _Purchase.Thickness = SubCat.Thickness;
                _Purchase.Width = SubCat.Width;
                _Purchase.Weight = SubCat.Weight;
                _Purchase.Quantity = _Inventory.Quantity;
                _Purchase.Price = SubCat.Price * nudCounter.Value;
                _Purchase.DateOfPurchase = DateTime.Now;
                _Purchase.SupplierID = ctrSuppliersCardWithFilter1.SuppliersID;
                _Purchase.SubCategoriesID = SubCat.ID;
                _Purchase.CategoryID = SubCat.CategoryID;
                _Purchase.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                _Purchase.NewInventoryID = _Inventory.IDInventory;
                if (_Purchase.Save())
                {
                    MessageBox.Show("Data Saved Succes ");
                }
                else
                {
                    MessageBox.Show("Some Error ,Contact Admin and Stop Working");
                }
            }
            else
                MessageBox.Show("Data Not Saved ");



        }
    }
}
