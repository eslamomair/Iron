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

namespace Iron.People
{
    public partial class ctrPersonCard : UserControl
    {
        private int _PersonID = -1;
        public ctrPersonCard()
        {
            InitializeComponent();
            llEditePersonInfo.Visible = false;
        }
        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPeoples SelectedPersonInfo
        {
            get
            {
                return _Person;
            }
        }

        
        private clsPeoples _Person;


        private void  _ResetPersonInfo()
        {
            lblPersonID.Text = string.Empty;
            lblName.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblPhone.Text = string.Empty;
            lblNational.Text = string.Empty;
            lblAddress.Text = string.Empty;
            llEditePersonInfo.Visible = false;
             
        }
        private void _LoadPersonImage()
        {
            string ImagePath = _Person.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonImage.ImageLocation = ImagePath;
                }
                else
                    MessageBox.Show("Could not find this Image", "Error");
            }
            else
                pbPersonImage.Image = Resources.Male_512;
        }
        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblEmail.Text = _Person.Email;
            lblNational.Text = _Person.NationalN;
            lblPhone.Text  =  _Person.Phone;
            lblAddress.Text = _Person.Address;
           
            llEditePersonInfo.Visible = true;
            _LoadPersonImage();
        }

        public void LoadPersonInfo(int PersonID)
        {
             
           
            _Person = clsPeoples.Find(PersonID);
            if (_Person == null  )
            {
                _ResetPersonInfo();
                MessageBox.Show("NO Person with PersonID = " + PersonID.ToString(), "Error");
                return;
            }
            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalN)
        {
            
            _Person = clsPeoples.Find(NationalN);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("NO Person with PersonID = " + NationalN.ToString(), "Error");
                return;
            }
            _FillPersonInfo();
        }

        private void llEditedPersonInfo_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdatePeople(_PersonID);
            form.ShowDialog();

            LoadPersonInfo(_PersonID);
        }
    }
}
