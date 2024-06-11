using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iron.Global_Classes;

namespace Iron.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUsers _User;
        public frmChangePassword( int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
        }

        private void _ResetDefaultValues()
        {

            txtCurrentPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            _UserID = -1;
            txtCurrentPassword.Focus();

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUsers.Find(_UserID);
            if (_User == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"User ID {_UserID} Not found","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrUserCard1.LoadUserInfo(_User.ID);
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Can't Password Empty");
            }
            else
                errorProvider1.SetError(txtCurrentPassword, null);


            if (clsGlobalUser.GetPasswordBeforeHashing( txtCurrentPassword.Text.Trim() )!= _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Wrong Password");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword , null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "Can't Password Empty");
            }
            else
                errorProvider1.SetError(txtNewPassword, null);

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Can't Password Empty");
            }
            else
                errorProvider1.SetError(txtConfirmPassword, null);


            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password not Matched");
            }
            else
                errorProvider1.SetError (txtConfirmPassword, null);
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Put The Red Icon To Read Error", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            


            _User.Password = clsGlobalUser.GetPasswordBeforeHashing( txtNewPassword.Text.Trim());

            if (_User.Save())
            {
                MessageBox.Show("Password Change Successfully");
            }
            else
            {
                MessageBox.Show("Password Not Change ");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
