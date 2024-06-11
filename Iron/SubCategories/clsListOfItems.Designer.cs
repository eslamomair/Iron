namespace Iron.SubCategories
{
    partial class frmListOfItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListOfItems = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCategoryValues = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvListItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordesCount = new System.Windows.Forms.Label();
            this.btnAddNewSubItems = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListOfItems
            // 
            this.lblListOfItems.AutoSize = true;
            this.lblListOfItems.Font = new System.Drawing.Font("Algerian", 30F);
            this.lblListOfItems.ForeColor = System.Drawing.Color.Crimson;
            this.lblListOfItems.Location = new System.Drawing.Point(473, 237);
            this.lblListOfItems.Name = "lblListOfItems";
            this.lblListOfItems.Size = new System.Drawing.Size(277, 45);
            this.lblListOfItems.TabIndex = 0;
            this.lblListOfItems.Text = "List of Items";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 15;
            this.cbFilterBy.BorderThickness = 3;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Items ID",
            "Items Name",
            "Category Class"});
            this.cbFilterBy.Location = new System.Drawing.Point(108, 285);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(227, 36);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter By :";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.txtFilterValue.BorderThickness = 3;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(367, 286);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(227, 36);
            this.txtFilterValue.TabIndex = 3;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // cbCategoryValues
            // 
            this.cbCategoryValues.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoryValues.BorderRadius = 15;
            this.cbCategoryValues.BorderThickness = 3;
            this.cbCategoryValues.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoryValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryValues.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoryValues.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoryValues.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.cbCategoryValues.ForeColor = System.Drawing.Color.Black;
            this.cbCategoryValues.ItemHeight = 30;
            this.cbCategoryValues.Items.AddRange(new object[] {
            "All",
            "مسطح",
            "بارد",
            "بقلاوه",
            "ساخن",
            "مجلفن",
            "مخلل",
            "ملون",
            "مط",
            "صنيبر",
            "مط ملون"});
            this.cbCategoryValues.Location = new System.Drawing.Point(354, 285);
            this.cbCategoryValues.Name = "cbCategoryValues";
            this.cbCategoryValues.Size = new System.Drawing.Size(227, 36);
            this.cbCategoryValues.TabIndex = 4;
            this.cbCategoryValues.SelectedIndexChanged += new System.EventHandler(this.cbCategoryValues_SelectedIndexChanged);
            // 
            // dgvListItems
            // 
            this.dgvListItems.AllowUserToAddRows = false;
            this.dgvListItems.AllowUserToDeleteRows = false;
            this.dgvListItems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvListItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvListItems.ColumnHeadersHeight = 40;
            this.dgvListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListItems.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvListItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListItems.Location = new System.Drawing.Point(16, 345);
            this.dgvListItems.Name = "dgvListItems";
            this.dgvListItems.ReadOnly = true;
            this.dgvListItems.RowHeadersVisible = false;
            this.dgvListItems.Size = new System.Drawing.Size(1218, 351);
            this.dgvListItems.TabIndex = 5;
            this.dgvListItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListItems.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvListItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListItems.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvListItems.ThemeStyle.ReadOnly = true;
            this.dgvListItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvListItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListItems.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(12, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "#Records";
            // 
            // lblRecordesCount
            // 
            this.lblRecordesCount.AutoSize = true;
            this.lblRecordesCount.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.lblRecordesCount.ForeColor = System.Drawing.Color.Green;
            this.lblRecordesCount.Location = new System.Drawing.Point(115, 720);
            this.lblRecordesCount.Name = "lblRecordesCount";
            this.lblRecordesCount.Size = new System.Drawing.Size(43, 31);
            this.lblRecordesCount.TabIndex = 7;
            this.lblRecordesCount.Text = "[...]";
            // 
            // btnAddNewSubItems
            // 
            this.btnAddNewSubItems.BorderColor = System.Drawing.Color.Maroon;
            this.btnAddNewSubItems.BorderRadius = 15;
            this.btnAddNewSubItems.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAddNewSubItems.BorderThickness = 3;
            this.btnAddNewSubItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewSubItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewSubItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewSubItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewSubItems.FillColor = System.Drawing.Color.White;
            this.btnAddNewSubItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewSubItems.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSubItems.Image = global::Iron.Properties.Resources.add_item_icon_vector_16301656;
            this.btnAddNewSubItems.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewSubItems.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewSubItems.Location = new System.Drawing.Point(1157, 263);
            this.btnAddNewSubItems.Name = "btnAddNewSubItems";
            this.btnAddNewSubItems.Size = new System.Drawing.Size(60, 59);
            this.btnAddNewSubItems.TabIndex = 9;
            this.btnAddNewSubItems.Click += new System.EventHandler(this.btnAddNewSubItems_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Image = global::Iron.Properties.Resources.paper_euclidean_vector_list_of_work_plans_5e658329d688458b95f26a2f5b29e58b;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(452, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(298, 228);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmListOfItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1246, 752);
            this.Controls.Add(this.btnAddNewSubItems);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblRecordesCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListItems);
            this.Controls.Add(this.cbCategoryValues);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblListOfItems);
            this.Name = "frmListOfItems";
            this.Text = "clsListOfItems";
            this.Load += new System.EventHandler(this.clsListOfItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListOfItems;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategoryValues;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordesCount;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewSubItems;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}