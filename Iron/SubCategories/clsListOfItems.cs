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

namespace Iron.SubCategories
{
    public partial class frmListOfItems : Form
    {
        private static DataTable _dtLisAllItemsClass = clsSubCategories.GetAllRows();
        private DataTable _dtListItems = _dtLisAllItemsClass.DefaultView.ToTable
            (false, "ID", "Type", "Thickness", "Width", "Weight", "Price", "CategoryID");
        public frmListOfItems()
        {
            InitializeComponent();
        }

        private void clsListOfItems_Load(object sender, EventArgs e)
        {

            dgvListItems.DataSource = _dtListItems;
            cbFilterBy.SelectedIndex = 0;

            if (dgvListItems.Rows.Count > 0)
            {
                dgvListItems.Columns[0].HeaderText = "ID";
                dgvListItems.Columns[0].Width = 80;

                dgvListItems.Columns[1].HeaderText = "Type Items";
                dgvListItems.Columns[1].Width = 190;

                dgvListItems.Columns[2].HeaderText = "Thickness";
                dgvListItems.Columns[2].Width = 80;

                dgvListItems.Columns[3].HeaderText = "Width";
                dgvListItems.Columns[3].Width = 80;

                dgvListItems.Columns[4].HeaderText = "Weight";
                dgvListItems.Columns[4].Width = 80;

                dgvListItems.Columns[5].HeaderText = "Price";
                dgvListItems.Columns[5].Width = 80;

                dgvListItems.Columns[6].HeaderText = "CategoryClass";
                dgvListItems.Columns[6].Width = 80;


            }

            lblRecordesCount.Text = _dtLisAllItemsClass.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Category Class")
            {
                txtFilterValue.Visible = false;
                cbCategoryValues.Visible = true;
                cbCategoryValues.Focus();
                cbCategoryValues.SelectedIndex = 0;


            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbCategoryValues.Visible = false;
                txtFilterValue.Focus();
                txtFilterValue.Text = "";
            }
        }



        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Items ID":
                    FilterColumn = "ID";
                    break;
                case "Items Name":
                    FilterColumn = "Type";
                    break;
                case "Category Class":
                    FilterColumn = "CategoryID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text == "" || FilterColumn == "None")
            {
                _dtListItems.DefaultView.RowFilter = "";
                lblRecordesCount.Text = dgvListItems.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Type")
            {
                _dtListItems.DefaultView.RowFilter = string.Format
                    ("[{0}] LIKE '%{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtListItems.DefaultView.RowFilter = string.Format
                    ("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }
            lblRecordesCount.Text = dgvListItems.Rows.Count.ToString();
        }

        private void cbCategoryValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterCoulmn = "CategoryID";
            string FilterValues = cbCategoryValues.Text;

            switch (cbCategoryValues.Text)
            {
                case "All":
                    break;
                case "مسطح":
                    FilterValues = "1";
                    break;

                case "بارد":
                    FilterValues = "2";
                    break;

                case "بقلاوه":
                    FilterValues = "3";
                    break;

                case "ساخن":
                    FilterValues = "4";
                    break;

                case "مجلفن":
                    FilterValues = "5";
                    break;

                case "مخلل":
                    FilterValues = "6";
                    break;

                case "ملون":
                    FilterValues = "7";
                    break;

                case "مط":
                    FilterValues = "8";
                    break;

                case "صنيبر":
                    FilterValues = "9";
                    break;

                case "مط ملون":
                    FilterValues = "10";
                    break;
            }

            if (FilterValues == "All")
            {
                _dtListItems.DefaultView.RowFilter = "";
                lblRecordesCount.Text = dgvListItems.Rows.Count.ToString();
            }
            else
            {
                _dtListItems.DefaultView.RowFilter = string.Format
                    ("[{0}] = {1}", FilterCoulmn, FilterValues);
            }
            lblRecordesCount.Text = dgvListItems.Rows.Count.ToString();
        }

        private void btnAddNewSubItems_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdateSubCategories();
            form.ShowDialog();
            _RefreshList();
        }

        void _RefreshList()
        {
            _dtLisAllItemsClass = clsSubCategories.GetAllRows();
            _dtListItems = _dtLisAllItemsClass.DefaultView.ToTable
          (false, "ID", "Type", "Thickness", "Width", "Weight", "Price", "CategoryID");

            dgvListItems.DataSource = _dtListItems;

            lblRecordesCount.Text = dgvListItems.Rows.Count.ToString();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            
                if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtFilterValue, "Can't be Empty");
                }
                else
                    errorProvider1.SetError(txtFilterValue, null);

            
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text != "Items Name")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
            }
        }
    }
}
