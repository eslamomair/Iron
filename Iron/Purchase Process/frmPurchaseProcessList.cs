using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.Purchase_Process
{
    public partial class frmPurchaseProcessList : Form
    {
        private static DataTable _dtAllPurchases = clsPurchases.ViewAllPurchases();
        public frmPurchaseProcessList()
        {
            InitializeComponent();
        }

        private void frmPurchaseProcessList_Load(object sender, EventArgs e)
        {
            dgvPurchaseList.DataSource = _dtAllPurchases;
          cbFilterBy.SelectedIndex = 0;
       
            if (dgvPurchaseList.Rows.Count >0)
            {
                dgvPurchaseList.Columns[0].HeaderText = "ID";
                dgvPurchaseList.Columns[0].Width = 70;

                dgvPurchaseList.Columns[1].HeaderText = "Name";
                dgvPurchaseList.Columns[1].Width = 200;

                dgvPurchaseList.Columns[2].HeaderText = "Categories";
                dgvPurchaseList.Columns[2].Width = 120;

                dgvPurchaseList.Columns[3].HeaderText = "Sub Categories";
                dgvPurchaseList.Columns[3].Width = 200;

                dgvPurchaseList.Columns[4].HeaderText = "Thickness";
                dgvPurchaseList.Columns[4].Width = 90;

                dgvPurchaseList.Columns[5].HeaderText = "Weight";
                dgvPurchaseList.Columns[5].Width = 90;

                dgvPurchaseList.Columns[6].HeaderText = "Width";
                dgvPurchaseList.Columns[6].Width = 90;

                dgvPurchaseList.Columns[7].HeaderText = "Quantity";
                dgvPurchaseList.Columns[7].Width = 90;

                dgvPurchaseList.Columns[8].HeaderText = "Price";
                dgvPurchaseList.Columns[8].Width = 90;

                dgvPurchaseList.Columns[9].HeaderText = "Date Of Purchase";
                dgvPurchaseList.Columns[9].Width = 120;

               
            }
           
            lblRecordesCount.Text = dgvPurchaseList.Rows.Count.ToString();

        }

        private void FilterValues_TextChanged(object sender, EventArgs e)
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
                case "Date Of Purchase":
                    FilterColumn = "DateOfPurchase";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }


            if (FilterColumn == "None" || txtFilterValues.Text == "")
            {
                _dtAllPurchases.DefaultView.RowFilter = "";
                lblRecordesCount.Text = dgvPurchaseList.Rows.Count.ToString();
                return;
            }

             if (FilterColumn == "FullName"  || FilterColumn == "ItemsType" ||
                 FilterColumn == "Type")
             {
                _dtAllPurchases.DefaultView.RowFilter = string.Format("[{0}] LIKE" +
                    "'%{1}%'", FilterColumn, txtFilterValues.Text.Trim());
            }
            else
            {
                _dtAllPurchases.DefaultView.RowFilter = string.Format
                    ("[{0}] = {1}",FilterColumn, txtFilterValues.Text.Trim());
            }
            lblRecordesCount.Text = dgvPurchaseList.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cbFilterBy.Text != "Date Of Purchase")
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;
                dtpDataFrom.Visible  = false;
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
            string FilterColumn = "DateOfPurchase";

         

          //  string filterExpression = $"DateOfPurchase >= #{dtpDataFrom.Value.ToShortTimeString()}# AND DateOfPurchase <= #{dtpDataTo.Value.ToShortTimeString()}#";

            // _dtAllPurchases هو DataTable الذي تريد البحث فيه
            _dtAllPurchases.DefaultView.RowFilter = $"[DateOfPurchase] >= '{dtpDataFrom.Value}' AND [DateOfPurchase] <= '{dtpDataTo.Value}'";

        }
       
        
    }
}
