using Iron.Global_Classes;
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

namespace Iron.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {

         

            clsUsers User = clsUsers.FindByUserNameAndPassword(txtUserName.Text.Trim(), ((txtPassword.Text.Length  <= 60  )? clsGlobalUser.GetPasswordBeforeHashing( txtPassword.Text.Trim()) : txtPassword.Text.Trim()));

            if (User != null)
            {
                if (chkRemmberMe.Checked)
                {
                    clsGlobalUser.RememberUsernameAndPasswordInRegistry(User.UserName,User.Password);
                }
                else
                {
                    clsGlobalUser.RememberUsernameAndPassword("", "");
                }

                if (!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your Account Is Not Active , Contact Your Admin");
                    return;
                }

            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Password or User name is valid");
                return;
            }

            clsGlobalUser.CurrentUser = User;
            this.Hide();
            frmMenu frmMenu = new frmMenu(this);
            frmMenu.ShowDialog();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobalUser.GetStoredCredentialInRegistry(ref UserName, ref Password))
            {
                txtPassword.Text = Password;
                txtUserName.Text = UserName;
                chkRemmberMe.Checked = true;
            }
            else
                chkRemmberMe.Checked = false;
           
        }
    }
}
