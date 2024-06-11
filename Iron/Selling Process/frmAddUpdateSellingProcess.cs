using Iron.Global_Classes;
using Iron.Suppliers.Controls;
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

namespace Iron.Selling_Process
{
    public partial class frmAddUpdateSellingProcess : Form
    {

        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _Sailing = -1;
        private clsSales  _Sales;
        private clsNewInventory _Inventory;
        clsSubCategories SubCat;



        public frmAddUpdateSellingProcess()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateSellingProcess(int sailing)
        {
            InitializeComponent();
            _Sailing = sailing;
            _Mode = enMode.Update;
        }

        private void FillTextDataWithSubCategorySelected()
        {
            SubCat = clsSubCategories.FindByType(cbSubCategory.Text);
            
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
            foreach (DataRow item in _dt.Rows)
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
                _Sales = new clsSales();
                _Inventory = new clsNewInventory();
               tpSellingProcess.Enabled = false;
                btnSave.Enabled = false;
                ctrCustomerCardWithFilter1.FilterFocus();
            }
            else
            {
                lbltitle.Text = "Update Purchase Process";
                this.Text = "Update Purchase Process";
               tpSellingProcess.Enabled = true;
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
            _Sales = clsSales.FindByID(_Sailing);
            _Inventory = clsNewInventory.FindByIDInventory(_Sales.NewInventoryID);
            ctrCustomerCardWithFilter1.FilterEnabled = false;
            cbLisItems.Enabled = false;
            cbSubCategory.Enabled = false;
            if (_Sales == null)
            {
                MessageBox.Show("There is no purchase process with this ID [" + _Sailing.ToString() + "]");
                return;
            }
            cbLisItems.SelectedIndex = cbLisItems.FindString(clsCategory.Find(_Sales.CategoryID).ItemsType);
            cbSubCategory.SelectedIndex = cbSubCategory.FindString(clsSubCategories.FindByID(_Sales.SubCategoriesID).Type);
            txtDateOfPurchase.Text = _Sales.DateOfSale.ToString();
            txtPrice.Text = _Sales.Price.ToString();
            txtThickness.Text = _Sales.Thickness.ToString();
            txtTotalAmount.Text = (_Sales.Quantity * _Sales.Price).ToString();
            txtWeight.Text = _Sales.Weight.ToString();
            txtWidth.Text = _Sales.Width.ToString();
            nudCounter.Value = _Sales.Quantity;
            ctrCustomerCardWithFilter1.LoadPersonInfo(_Sales.CustomerID);

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


        private void frmAddUpdateSellingProcess_Load(object sender, EventArgs e)
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
                tpSellingProcess.Enabled = true;
                tcSelling.SelectedTab = tcSelling.TabPages["tpSellingProcess"];
                return;
            }

            if (ctrCustomerCardWithFilter1.CustomerID != -1)
            {
                btnSave.Enabled = true;
                tpSellingProcess.Enabled = true;
                tcSelling.SelectedTab = tcSelling.TabPages["tpSellingProcess"];
            }
            else
            {
                MessageBox.Show("Can't Enabled The Selling Process Without Suppliers");
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
            txtTotalAmount.Text = (Convert.ToDecimal(txtPrice.Text) * nudCounter.Value).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                _Sales.Thickness = SubCat.Thickness;
                _Sales.Width = SubCat.Width;
                _Sales.Weight = SubCat.Weight;
                _Sales.Quantity = _Inventory.Quantity;
                _Sales.Price = SubCat.Price * nudCounter.Value;
                _Sales.DateOfSale = DateTime.Now;
                _Sales.CustomerID = ctrCustomerCardWithFilter1.CustomerID;
                _Sales.SubCategoriesID = SubCat.ID;
                _Sales.CategoryID = SubCat.CategoryID;
                _Sales.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                _Sales.NewInventoryID = _Inventory.IDInventory;
                if (_Sales.Save())
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

