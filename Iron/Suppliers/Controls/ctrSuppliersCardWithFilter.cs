using Iron.Customers;
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

namespace Iron.Suppliers.Controls
{
    public partial class ctrSuppliersCardWithFilter : UserControl
    {
        public event Action<int> OnSuppliersSelected;
        protected virtual void SuppliersSelected(int SuppliersID)
        {
            Action < int> Handler = OnSuppliersSelected;
            if (Handler != null)
            {
                Handler(SuppliersID);
            }
        }
        public ctrSuppliersCardWithFilter()
        {
            InitializeComponent();

        }


        int _SuppliersID = -1;
        public int SuppliersID
        {
            get { return _SuppliersID; }

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

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            set
            {
                _ShowAddPerson = value;
                btnAddNew.Visible = _ShowAddPerson;
            }
            get
            {
                return _ShowAddPerson;
            }
        }

        private clsSuppliers _Suppliers;
        public clsSuppliers SelectedSuppliersInfo
        {
            get
            {
                return ctrSuppliersCard1.SelectedSuppliers;
            }
        }

        public void LoadSuppliersInfo(int  suppliersID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = suppliersID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Suppliers ID":
                    ctrSuppliersCard1.LoadSuppliersInfo(int.Parse(txtFilterValue.Text));
                    break;
                case "National N":
                    ctrSuppliersCard1.LoadSuppliersInfo(txtFilterValue.Text);
                    break;
            }

            if (OnSuppliersSelected != null && FilterEnabled)
            {
                OnSuppliersSelected(ctrSuppliersCard1.SuppliersID);
            }
            if (ctrSuppliersCard1.SuppliersID != -1)
            {
                _SuppliersID = ctrSuppliersCard1.SuppliersID;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Failed Required");
                return;
            }
            FindNow();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "Put The Mouse In Red Icon To Read Error");
            }
            else
                errorProvider1.SetError(txtFilterValue, null);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void ctrSuppliersCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void DataBackEvent(object sender, int SuppliersID)
        {
            txtFilterValue.Text = SuppliersID.ToString();
            cbFilterBy.SelectedIndex = 1; 
            ctrSuppliersCard1.LoadSuppliersInfo(SuppliersID);
        }
    }
}