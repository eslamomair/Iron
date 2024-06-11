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

namespace Iron.Category
{
    public partial class frmShowAllCategory : Form
    {
        private static DataTable _dtAllCategory = clsCategory.GetAllCategory();

        public frmShowAllCategory()
        {
            InitializeComponent();
        }

        private void frmShowAllCategory_Load(object sender, EventArgs e)
        {
            dgvListAllCategory.DataSource = _dtAllCategory;

            if (dgvListAllCategory.Rows.Count > 0)
            {
                dgvListAllCategory.Columns[0].HeaderText = "ID";
                dgvListAllCategory.Columns[0].Width = 50;

                dgvListAllCategory.Columns[1].HeaderText = "ItemsType";
                dgvListAllCategory.Columns[1].Width = 150;

                dgvListAllCategory.Columns[2].HeaderText = "Description";
                dgvListAllCategory.Columns[2].Width = 320;



            }

            lblRecordes.Text = dgvListAllCategory.Rows.Count.ToString();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmEditCategory((int)dgvListAllCategory.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }
    }
}
