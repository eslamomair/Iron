using Iron.Global_Classes;
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


namespace Iron.Customers
{
    public partial class frmAddUpdatePeople : Form
    {
        public delegate void DataBackHandler(object sender, int customerID);
        public event DataBackHandler DataBack;

        public enum enMode { AddNew = 0 , Update = 1 }
        private enMode _Mode;
         
        private clsPeoples _Peoples;
        private int PersonID;
        public frmAddUpdatePeople()
        {
            InitializeComponent();
        }
        public frmAddUpdatePeople(int ID)
        {
            InitializeComponent();
            PersonID = ID;
            _Mode = enMode.Update;
        }
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person";
                _Peoples = new clsPeoples();
                
            }
            else
            {
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";
                 
            }

            lblCustomerID.Text = "[N/A]";
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtNationalN.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            pbPersonImage.Image = Resources.Male_512;
        }

        private void  _LoadData()
        {
             
            _Peoples = clsPeoples.Find(PersonID);

            if (_Peoples == null)
            {
                MessageBox.Show("Some Error , Application  will be Close");
                return;
            }


            lblCustomerID.Text = _Peoples.PersonID.ToString();
            txtFirstName.Text = _Peoples.FirstName.ToString();
            txtSecondName.Text = _Peoples.SecondName.ToString();
            txtThirdName.Text = _Peoples.ThirdName.ToString();
            txtLastName.Text = _Peoples.LastName.ToString();
            txtEmail.Text = _Peoples.Email.ToString();
            txtNationalN.Text = _Peoples.NationalN.ToString();
            txtAddress.Text  = _Peoples.Address.ToString();
            txtPhone.Text = _Peoples.Phone.ToString();
            if (_Peoples.ImagePath  != "")
            {
                pbPersonImage.ImageLocation = _Peoples.ImagePath;
            }
            else
            {
                pbPersonImage.Image = Resources.Male_512;
            }

            llRemoveImage.Visible = (_Peoples.ImagePath != "");
        }
        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Temp = (Guna.UI2.WinForms.Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "Please place the mouse cursor over the red mark to know the requirements.");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtNationalN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalN.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalN, "Please place the mouse cursor over the red mark to know the requirements.");
            }
            else
            {
                errorProvider1.SetError(txtNationalN, null);
            }

            if (txtNationalN.Text.Length < txtNationalN.MaxLength )
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalN, "The National ID number cannot be less than 14 digits.");
            }
            else
            errorProvider1.SetError(txtNationalN,null);

            if (txtNationalN.Text.Trim() != _Peoples.NationalN &&   clsPeoples.IsPersonExist(txtNationalN.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalN, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtNationalN, null);
            }
             
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Please place the mouse cursor over the red mark to know the requirements.");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }

            if (!clsValidation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Please Very a mail ");

            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter  = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = "";
                selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.ImageLocation = (selectedFilePath);

                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            pbPersonImage.Image = Resources.Male_512;

           // llSetImage.Visible = true;

            llRemoveImage.Visible = false;
        }



        private bool _HandlePersonImage()
        {
            if (_Peoples.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Peoples.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Peoples.ImagePath);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                   
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private bool SavePersonDate()
        {
            

                _Peoples.FirstName = txtFirstName.Text.Trim();
                _Peoples.SecondName = txtSecondName.Text.Trim();
                _Peoples.ThirdName = txtThirdName.Text.Trim();
                _Peoples.LastName = txtLastName.Text.Trim();
                if (txtNationalN.Text.Trim() != "")
                {
                    _Peoples.NationalN = txtNationalN.Text.Trim();
                }
                else
                    _Peoples.NationalN = "";

                _Peoples.Phone = txtPhone.Text.Trim();

                if (txtEmail.Text.Trim() != "")
                {
                    _Peoples.Email = txtEmail.Text.Trim();
                }
                else
                    _Peoples.Email = "";

                _Peoples.Address = txtAddress.Text.Trim();

                if (pbPersonImage.ImageLocation != null)
                {
                    _Peoples.ImagePath = pbPersonImage.ImageLocation;
                }
                else
                    _Peoples.ImagePath = "";
                if (_Peoples.Save())
                    return true;
           
          
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Failed is Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (!_HandlePersonImage())
            {
                return; 
            }

            if (SavePersonDate())
            {
                 
                  MessageBox.Show("Data Saved Successfully");
               
                    lblCustomerID.Text = _Peoples.PersonID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                DataBack?.Invoke(this, _Peoples.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
