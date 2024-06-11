using Iron.People;
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

namespace Iron.Customers.Control
{
    public partial class ctrCustomerCardWithFilter : UserControl
    {
        public event Action<int> OnCustomerSelected;
        protected virtual void CustomerSelected(int customerId)
        {
            Action<int> handler = OnCustomerSelected;
            if (handler!=null)
            {
                handler(customerId);
            }
        }
        public ctrCustomerCardWithFilter()
        {
            InitializeComponent();
        }

        private int _CustomerID = -1;

        public int CustomerID
        {
            get { return ctrCustomerCard1.CustomerID; }
        }

        public clsCustomers SelectedPersonInfo
        {
            get { return ctrCustomerCard1.SelectedCustomerInfo; }
        }

        private bool _ShowAddPerson = true; 
        public bool ShowAddPerson
        {
            set
            {
                _ShowAddPerson = value;
                btnAddNewCustomer.Visible = _ShowAddPerson;
            }
            get { return _ShowAddPerson; }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            set
            {
                _FilterEnabled = value;
                gpFilter.Enabled = _FilterEnabled;
            }
            get
            {
                return _FilterEnabled;
            }
        }
        private void _FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Customer ID":
                    ctrCustomerCard1.LoadCustomerInfo(int.Parse(txtFilterValue.Text.Trim()));
                    break;
            }

            if (OnCustomerSelected != null && FilterEnabled)
            {
                OnCustomerSelected(ctrCustomerCard1.CustomerID);
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
           cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();

            _FindNow();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnSarch_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Fields not Veiled");
                return;
            }
            _FindNow();
        }

        private void ctrCustomerCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "Some Field Not Failed");
            }
            else
                errorProvider1.SetError(txtFilterValue, null);
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
        private void DataBackEvent(object sender,int CustomerID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = CustomerID.ToString();
            ctrCustomerCard1.LoadCustomerInfo(CustomerID);
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnSarch.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }
    }
}
