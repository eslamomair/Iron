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

namespace Iron.Category
{
    public partial class frmEditCategory : Form
    {
        int ID;
        clsCategory _Category;
        public frmEditCategory(int iD)
        {
            InitializeComponent();
            ID = iD;
        }

        void _RestDefualtValues()
        {
            lblID.Text = string.Empty;
            txtDetails.Text = string.Empty;
            txtType.Text = string.Empty;
            ID = -1;
        }
        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            _Category = clsCategory.Find(ID);
            if (_Category==null)
            {
                _RestDefualtValues();
                MessageBox.Show("Some Error");
                return;
            }

            _FillData();
        }

        void _FillData()
        {
            lblID.Text = _Category.CategoryID.ToString();
            txtType.Text = _Category.ItemsType.ToString();
            txtDetails.Text = _Category.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Category.ItemsType = txtType.Text.Trim();
            _Category.Description = txtDetails.Text.Trim();
            if (_Category.Save())
            {
                MessageBox.Show("Data Saved Successfully");
               
            }
            else
                MessageBox.Show("Data Not  Saved");
        }

        private void txtType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtType.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtType, "Can't be Empty");
            }
            else
            {
                errorProvider1.SetError(txtType, null);
            }
        }

        private void txtDetails_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDetails.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDetails, "Can't be Empty");
            }
            else
            {
                errorProvider1.SetError(txtDetails, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
