using Iron.Customers;
using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.People
{
    public partial class ctrPersonCardWithFilter : UserControl
    {

        public event Action  <int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;
            if (Handler != null)
            {
                Handler(PersonID);
            }
        }

        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
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

        private bool _FilterEnabled=true;
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

        private int _PersonID = -1;

        public int PersonID
        {

            get { return ctrPersonCard1.PersonID; }
        }

        public clsPeoples SelectedPersonInfo
        {
            get
            {
                return ctrPersonCard1.SelectedPersonInfo;
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            _FindNow();
        }

        private void _FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text)); 
                   
                    break;
                case "National N":
                    ctrPersonCard1.LoadPersonInfo(txtFilterValue.Text.Trim());
                   
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
            {
                OnPersonSelected(ctrPersonCard1.PersonID);
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid");
                return;
            }

            _FindNow();
        }

        private void ctrPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            txtFilterValue.Focus();
            cbFilterBy.SelectedIndex = 0;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            ctrPersonCard1.LoadPersonInfo(PersonID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
            if (cbFilterBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "put The Red Icon");
            }
            else
                errorProvider1.SetError(txtFilterValue, null);
        }
    }
}
