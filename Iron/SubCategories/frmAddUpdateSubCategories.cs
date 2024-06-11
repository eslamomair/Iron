using Iron.Global_Classes;
using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.SubCategories
{
    public partial class frmAddUpdateSubCategories : Form
    {
        private bool _gpInformation;
        public bool gpInformation
        {
            set
            {
                _gpInformation = value;
                gpSub.Enabled = _gpInformation;
            }
            get
            {

                return _gpInformation;
            }
        
   
        }
        private int _SubCategoryID;
        public enum enMode { AddNew = 0, Update=1 };
        private enMode _Mode;
        clsSubCategories _SubCategories;
         
        public frmAddUpdateSubCategories()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }


        public frmAddUpdateSubCategories(int SubCategory )
        {
            InitializeComponent();
            _SubCategoryID = SubCategory;
            _Mode = enMode.Update;
        }

        private void FillCbCategory()
        {
            DataTable dt = clsCategory.GetAllCategory();
            foreach (DataRow Rows in dt.Rows)
            {
                cbCategor.Items.Add(Rows["ItemsType"]);
               
            }
        }

        private void _ResetDefaultValues()
        {
            FillCbCategory();
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Sub Category";
                this.Text = lblTitle.Text;
                _SubCategories = new clsSubCategories();
                gpSub.Enabled = false;
                
            }
            else
            {
                lblTitle.Text = "Update Sub Category";
                this.Text= lblTitle.Text;
                gpSub.Enabled = true;
                cbCategor.Enabled = false;
               
            }

            lblID.Text = "[...]";
            txtPrice.Text = string.Empty;
            txtThichness.Text = string.Empty;
            txtType.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtWidth.Text = string.Empty;
        }
        private void frmAddUpdateSubCategories_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            cbCategor.SelectedIndex = 0;

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void _LoadData()
        {
            _SubCategories = clsSubCategories.FindByID(_SubCategoryID);


            if (_SubCategories == null)
            {
                MessageBox.Show("Error , Sub Categories Is Not Found ");
                return; 
            }

            cbCategor.SelectedIndex = cbCategor.FindString(clsCategory.Find(_SubCategories.CategoryID).ItemsType);

            lblID.Text        = _SubCategories.ID.ToString();
            txtPrice.Text     = _SubCategories.Price.ToString();
            txtThichness.Text = _SubCategories.Thickness.ToString();
            txtType.Text      = _SubCategories.Type.ToString();
            txtWeight.Text    = _SubCategories.Weight.ToString();
            txtWidth.Text     = _SubCategories.Width.ToString();
        }

        private void AllText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
        }


        private void AllTextNotEmpty_Validating(object sender, CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Temp = (Guna.UI2.WinForms.Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "Can't be Empty ");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            };

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Text Is Empty,Put The Mouse to read The Error");
                return;
            }


            _SubCategories.Price = Convert.ToDecimal(txtPrice.Text.Trim(), CultureInfo.InvariantCulture);
            _SubCategories.Thickness= decimal.Parse(txtThichness.Text.Trim());
              _SubCategories.Type= txtType.Text.Trim();
              _SubCategories.Weight=decimal.Parse(txtWeight.Text.Trim());
              _SubCategories.Width=decimal.Parse(txtWidth.Text.Trim());
            _SubCategories.CreatedByUserID = clsGlobalUser.CurrentUser.PersonID;
            _SubCategories.CategoryID = clsCategory.Find(cbCategor.Text).CategoryID;
            if (_SubCategories.Save())
            {
                lblID.Text = _SubCategories.ID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Category";
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Data Not Save");
            }
                                     
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpInformation = (cbCategor.Text != "None");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }                                
}                                    
                                     