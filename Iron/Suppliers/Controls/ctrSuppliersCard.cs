using Iron.Customers;
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

namespace Iron.Suppliers.Controls
{
    public partial class ctrSuppliersCard : UserControl
    {
        public ctrSuppliersCard()
        {
            InitializeComponent();
            llEditePersonInfo.Visible = false;
            
        }

        private int _SuppliersID = -1;
        public int SuppliersID
        {
            get {return _SuppliersID;}
        }
        private clsPeoples _People;
        private clsSuppliers _Suppliers;
        public clsSuppliers SelectedSuppliers
        { get {return _Suppliers;} }
        private void _ResetDefaultValue()
        {
            _SuppliersID = -1;
            lblPersonID.Text = string.Empty;
            lblName.Text = string.Empty;
            lblNational.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblPhone.Text = string.Empty;
            lblAddress.Text = string.Empty;
            llEditePersonInfo.Visible = false;
        }

        private void _LoadImageSuppliers()
        {
            string ImagePath = _Suppliers.People.ImagePath;
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
                pbPersonImage.ImageLocation= null;
                pbPersonImage.Image = Resources.Man_32;
            }
        }

        private void _FillSuppliersInfo()
        {
            lblPersonID.Text = _Suppliers.ID.ToString();
            lblName.Text = _Suppliers.People.FullName;
            lblNational.Text = _Suppliers.People.NationalN;
            lblPhone.Text = _Suppliers.People.Phone;
            lblEmail.Text = _Suppliers.People.Email;
            lblAddress.Text = _Suppliers.People.Address;
            llEditePersonInfo.Visible = true;
            _SuppliersID = _Suppliers.ID;
            _LoadImageSuppliers();
        }

        public void LoadSuppliersInfo(int SuppliersID)
        {
            _Suppliers = clsSuppliers.Find(SuppliersID);

            if (_Suppliers == null)
            {
                _ResetDefaultValue();
                MessageBox.Show($"The Suppliers is  ID {SuppliersID} Not Found ");
                return;
            }

            _FillSuppliersInfo();

        }


        public void LoadSuppliersInfo(string NationalN)
        {
           _People= clsPeoples.Find(NationalN);
            _Suppliers = clsSuppliers.FindByPersonID(_People.PersonID);

            if (_Suppliers == null)
            {
                _ResetDefaultValue();
                MessageBox.Show($"The Suppliers is  ID {NationalN} Not Found ");
                return;
            }

            _FillSuppliersInfo();

        }




        private void llEditedPersonInfo_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople(_Suppliers.People.PersonID);
            frm.ShowDialog();
            LoadSuppliersInfo(_SuppliersID);
        }
    }
    
}
