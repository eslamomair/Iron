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
    public partial class frmListAllSailingProcess : Form
    {
        private static DataTable _dtViewAllSailing = clsSales.GetAllSailing();
        public frmListAllSailingProcess()
        {
            InitializeComponent();
        }

        private void frmListAllSailingProcess_Load(object sender, EventArgs e)
        {
            dgvSleingList.DataSource = _dtViewAllSailing;
            cbFilterBy.SelectedIndex = 0;

            if (dgvSleingList.Rows.Count > 0)
            {
                dgvSleingList.Columns[0].HeaderText = "ID";
                dgvSleingList.Columns[0].Width = 70;
             
                dgvSleingList.Columns[1].HeaderText = "Name";
                dgvSleingList.Columns[1].Width = 200;
               
                dgvSleingList.Columns[2].HeaderText = "Categories";
                dgvSleingList.Columns[2].Width = 120;
             
                dgvSleingList.Columns[3].HeaderText = "Sub Categories";
                dgvSleingList.Columns[3].Width = 200;
           
                dgvSleingList.Columns[4].HeaderText = "Thickness";
                dgvSleingList.Columns[4].Width = 90;
               
                dgvSleingList.Columns[5].HeaderText = "Weight";
                dgvSleingList.Columns[5].Width = 90;
               
                dgvSleingList.Columns[6].HeaderText = "Width";
                dgvSleingList.Columns[6].Width = 90;
              
                dgvSleingList.Columns[7].HeaderText = "Quantity";
                dgvSleingList.Columns[7].Width = 90;
              
                dgvSleingList.Columns[8].HeaderText = "Price";
                dgvSleingList.Columns[8].Width = 90;
             
                dgvSleingList.Columns[9].HeaderText = "Date Of Sale";
                dgvSleingList.Columns[9].Width = 120;


            }

            lblRecordesCount.Text = dgvSleingList.Rows.Count.ToString();

        }

        private void txtFilterValues_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "ID":
                    FilterColumn = "ID";
                    break;
                case "Name":
                    FilterColumn = "FullName";
                    break;
                case "Categories":
                    FilterColumn = "ItemsType";
                    break;
                case "Sub Categories":
                    FilterColumn = "Type";
                    break;
                case "Thickness":
                    FilterColumn = "Thickness";
                    break;
                case "Weight":
                    FilterColumn = "Weight";
                    break;
                case "Width":
                    FilterColumn = "Width";
                    break;
                case "Quantity":
                    FilterColumn = "Quantity";
                    break;
                case "Price":
                    FilterColumn = "Price";
                    break;
                case "Date Of Sale":
                    FilterColumn = "DateOfSale";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }


            if (FilterColumn == "None" || txtFilterValues.Text == "")
            {
                _dtViewAllSailing.DefaultView.RowFilter = "";
                lblRecordesCount.Text = dgvSleingList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "FullName" || FilterColumn == "ItemsType" ||
                FilterColumn == "Type")
            {
                _dtViewAllSailing.DefaultView.RowFilter = string.Format("[{0}] LIKE" +
                    "'%{1}%'", FilterColumn, txtFilterValues.Text.Trim());
            }
            else
            {
                _dtViewAllSailing.DefaultView.RowFilter = string.Format
                    ("[{0}] = {1}", FilterColumn, txtFilterValues.Text.Trim());
            }
            lblRecordesCount.Text = _dtViewAllSailing.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.Text != "Date Of Sale")
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;
                dtpDataFrom.Visible = false;
                dtpDataTo.Visible = false;

                txtFilterValues.Visible = true;
                txtFilterValues.Focus();
                txtFilterValues.Visible = (cbFilterBy.Text != "None");
            }
            else
            {

                lblFrom.Visible = true;
                lblTo.Visible = true;
                dtpDataFrom.Visible = true;
                dtpDataTo.Visible = true;
                txtFilterValues.Visible = false;
            }
        }

        private void dtpDataTo_ValueChanged(object sender, EventArgs e)
        {
            _dtViewAllSailing.DefaultView.RowFilter = $"[DateOfSale] >= '{dtpDataFrom.Value}' AND [DateOfSale] <= '{dtpDataTo.Value}'";
        }
    }
}
