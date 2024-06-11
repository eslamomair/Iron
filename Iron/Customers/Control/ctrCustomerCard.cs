using Iron.Properties;
using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.Customers.Control
{
    public partial class ctrCustomerCard : UserControl
    {
        public ctrCustomerCard()
        {
            InitializeComponent();
            llEditePersonInfo.Visible = false;
        }

        private int _CustomerID = -1;
        public int  CustomerID
        {
            get
            {
                return _CustomerID;
            }
        }

        private clsCustomers _Customer;
        public clsCustomers SelectedCustomerInfo
        {
            get { return _Customer; }
        }

        private void _ResetDefaultValue()
        {
            _CustomerID = -1;
            lblPersonID.Text = string.Empty;
            lblName.Text = string.Empty;
            lblNational.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblPhone.Text = string.Empty;
            lblAddress.Text = string.Empty;
            llEditePersonInfo.Visible = false;
        }

        private void _LoadCustomerImage()
        {
            string ImagePath = _Customer.Peoples.ImagePath;
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonImage.ImageLocation = ImagePath;
                }
                else
                    MessageBox.Show("Could not find this Image " + ImagePath.ToString());
            }
            else
            {
                pbPersonImage.ImageLocation = null;
                pbPersonImage.Image = Resources.Male_512;
            }
        }
        private void _FillCustomerCard()
        {
            lblPersonID.Text = _Customer.ID.ToString();
            lblName.Text = _Customer.Peoples.FullName;
            lblNational.Text = _Customer.Peoples.NationalN;
            lblEmail.Text = _Customer.Peoples.Email;
            lblPhone.Text = _Customer.Peoples.Phone;
            lblAddress.Text = _Customer.Peoples.Address;
            llEditePersonInfo.Visible = true;
            _CustomerID = _Customer.ID;
            _LoadCustomerImage();
        }
        public void LoadCustomerInfo(int  customerID)
        {
             _Customer = clsCustomers.Find(customerID);
            
            if (_Customer == null)
            {
                _ResetDefaultValue();
                MessageBox.Show("not Found Customer ID " + customerID.ToString(), "Error");
                return;
            }
            _FillCustomerCard();
        }

      

        private void llEditedPersonInfo_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople(_Customer.PersonID);
            frm.ShowDialog();

            LoadCustomerInfo(_Customer.PersonID);
        }


    }
}
