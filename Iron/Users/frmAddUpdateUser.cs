using Iron.Global_Classes;
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

namespace Iron.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0 , Update = 1 }
        private enMode _Mode;

        private int _UserID = -1;
        private clsUsers _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }
        public frmAddUpdateUser(int UserId)
        {
            InitializeComponent();
            _UserID = UserId;
        }

        private void _ResetDefaultValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUsers();

                tpLoginInfo.Enabled = false;

                ctrPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = false;
        }

        private void _LoadData()
        {
            _User = clsUsers.Find(_UserID);
            ctrPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No Person With ID " + _UserID, "User Not Found");
                this.Close();
                return;
            }

            lblUserID.Text = _User.ID.ToString();
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrPersonCardWithFilter1.LoadPersonInfo(_User.ID);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tbUsers.SelectedTab = tbUsers.TabPages["tpLoginInfo"];
                return;
            }

            if (ctrPersonCardWithFilter1.PersonID != -1)
            {
                if (clsUsers.IsUserExistForPersonID(ctrPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user ,choose anther one");
                    ctrPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tbUsers.SelectedTab = tbUsers.TabPages["tpLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person ", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ctrPersonCardWithFilter1.FilterFocus();
            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Failed ");
                return;
            }

            _User.PersonID = ctrPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = clsGlobalUser.GetPasswordBeforeHashing(  txtPassword.Text.Trim());
            _User.IsActive = chkIsActive.Checked;
            _User.DataCreated = DateTime.Now;

            if (_User.Save())
            {
                lblUserID.Text = _User.ID.ToString();


                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                MessageBox.Show("Data Saved Successfully", "Saved");
            }
            else
                MessageBox.Show("Data Not Saved ");
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsUsers.IsUserExistByUserName(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUsers.IsUserExistByUserName(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
