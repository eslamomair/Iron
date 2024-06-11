using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.People
{
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            ctrPersonCard1.LoadPersonInfo(PersonID);
        }
        
        public frmPersonDetails(string NationalN)
        {
            InitializeComponent();
            ctrPersonCard1.LoadPersonInfo(NationalN);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
