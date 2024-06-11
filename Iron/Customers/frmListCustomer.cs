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

namespace Iron.Customers
{
    public partial class frmListCustomer : Form
    {
        private int PersonID = -1;
        private static DataTable _dtAllCustomer = clsCustomers.GetAllCustomerWithPersonsInfo();

        private DataTable _dtCustomer = _dtAllCustomer.DefaultView.ToTable(false,
            "ID", "FirstName", "SecondName", "ThirdName", "LastName", "NationalN", "Phone",
            "Email", "Address", "ImagePath");


        public frmListCustomer()
        {
            InitializeComponent();
        }

        void _RefreshPeopleList()
        {
            _dtCustomer = _dtAllCustomer.DefaultView.ToTable(false,
            "ID", "FirstName", "SecondName", "ThirdName", "LastName", "NationalN", "Phone",
            "Email", "Address", "ImagePath");

            dgvListAllCustome.DataSource = _dtCustomer;
            llCountRecord.Text = dgvListAllCustome.Rows.Count.ToString();
        }

        private void frmListCustomer_Load(object sender, EventArgs e)
        {
            dgvListAllCustome.DataSource = _dtCustomer;

            if (dgvListAllCustome.Rows.Count>0)
            {
                dgvListAllCustome.Columns[0].HeaderText = "ID";
                dgvListAllCustome.Columns[0].Width = 90;

                dgvListAllCustome.Columns[1].HeaderText = "First Name";
                dgvListAllCustome.Columns[1].Width = 120;

                dgvListAllCustome.Columns[2].HeaderText = "Second Name";
                dgvListAllCustome.Columns[2].Width = 120;

                dgvListAllCustome.Columns[3].HeaderText = "Third Name";
                dgvListAllCustome.Columns[3].Width = 120;

                dgvListAllCustome.Columns[4].HeaderText = "Last Name";
                dgvListAllCustome.Columns[4].Width = 120;

                dgvListAllCustome.Columns[5].HeaderText = "National N";
                dgvListAllCustome.Columns[5].Width = 150;

                dgvListAllCustome.Columns[6].HeaderText = "Phone";
                dgvListAllCustome.Columns[6].Width = 150;

                dgvListAllCustome.Columns[7].HeaderText = "Email";
                dgvListAllCustome.Columns[7].Width = 170;

                dgvListAllCustome.Columns[8].HeaderText = "Address";
                dgvListAllCustome.Columns[8].Width = 200;

                dgvListAllCustome.Columns[9].HeaderText = "Image Path";
                dgvListAllCustome.Columns[9].Width = 250;


            }

            cbFilterBy.SelectedIndex = 0;
           llCountRecord.Text = dgvListAllCustome.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnFilter = "";
            switch (cbFilterBy.Text)
            {
                case "Customer ID":
                    ColumnFilter = "ID";
                    break;
                case "First Name":
                    ColumnFilter = "FirstName";
                    break;
                case "Last Name":
                    ColumnFilter = "LastName";
                    break;
                case "National N":
                    ColumnFilter = "NationalN";
                    break;
                case "Phone":
                    ColumnFilter = "Phone";
                    break;
                case "Address":
                    ColumnFilter = "Address";
                    break;
                case "Email":
                    ColumnFilter = "Email";
                    break;
                default:
                    ColumnFilter = "None";
                    break;
            }


            if (ColumnFilter == "None" || txtFilterValue.Text.Trim() == "")
            {
                _dtCustomer.DefaultView.RowFilter = "";
                llCountRecord.Text = dgvListAllCustome.Rows.Count.ToString();
                return;
            }

            if (ColumnFilter  == "ID")
            {
                _dtCustomer.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnFilter, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtCustomer.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnFilter, txtFilterValue.Text.Trim());
            }

            llCountRecord.Text = dgvListAllCustome.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmCustomerDetails(int.Parse(dgvListAllCustome.CurrentRow.Cells[0].Value.ToString()));
            form.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdatePeople();
            form.ShowDialog();
            _RefreshPeopleList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdatePeople(int.Parse(dgvListAllCustome.CurrentRow.Cells[0].Value.ToString()));
            form.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Are You Sure you Want to Delete Person[" + dgvListAllCustome.CurrentRow.Cells[0].Value.ToString() +"]" ,"Confirm Delete", MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.OK)
            {
                int personId = int.Parse(_dtAllCustomer.Rows[dgvListAllCustome.CurrentRow.Index]["PersonID"].ToString());

                if (clsCustomers.DeleteCustomerByID(int.Parse(dgvListAllCustome.CurrentRow.Cells[0].Value.ToString())))
                {
                    if (clsPeoples.DeletePerson(personId))
                    {
                        MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshPeopleList();
                    }
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Person was not deleted because you Choose Cancel.", "Canceling", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
            AddNewCustomerWithDataBack();
        }

        private void DataBackEvent(object sender, int customerID)
        {
            PersonID = customerID;
        }

        private void AddNewCustomerWithDataBack()
        {
            if (PersonID > 0)
            {
                clsCustomers customers = new clsCustomers();
                customers.PersonID = PersonID;
                customers.CreatedByUserID = 1;// Che
                if (customers.Save())
                {
                    MessageBox.Show("Data Saved ");
                }
                else
                    MessageBox.Show("Data Not Saved");
            }
        }
    }
}


