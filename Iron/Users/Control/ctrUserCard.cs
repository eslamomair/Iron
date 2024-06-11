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

namespace Iron.Users.Control
{
    public partial class ctrUserCard : UserControl
    {
        public ctrUserCard()
        {
            InitializeComponent();
        }

        private int _UserID = -1;
        public int UserID
        {
            get { return _UserID; }
        }

        private clsUsers _User;

        private void _ResetPersonInfo()
        {
            lblIsActive.Text = "[...]";
            lblUseName.Text = "[...]";
            lblUserID.Text = "[...]";
        }
        public void LoadUserInfo(int UserID)
        {
            _User = clsUsers.Find(UserID);

            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User With User ID ");
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            _UserID = UserID;
            ctrPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.ID.ToString();
            lblUseName.Text = _User.UserName;
            if (_User.IsActive)
            {
                lblIsActive.Text = "Yes";
            }
            else
                lblIsActive.Text = "No";
        }
    }
}
