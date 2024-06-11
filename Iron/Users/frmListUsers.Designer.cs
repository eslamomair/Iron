namespace Iron.Users
{
    partial class frmListUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterValues = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvListAllUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmCustomer = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sendMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAllUsers)).BeginInit();
            this.cmCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Iron.Properties.Resources.Users_2_400;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(410, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(247, 167);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sukar", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(427, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By :";
            // 
            // txtFilterValues
            // 
            this.txtFilterValues.BorderColor = System.Drawing.Color.Gray;
            this.txtFilterValues.BorderRadius = 16;
            this.txtFilterValues.BorderThickness = 3;
            this.txtFilterValues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValues.DefaultText = "";
            this.txtFilterValues.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValues.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValues.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValues.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.txtFilterValues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFilterValues.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValues.Location = new System.Drawing.Point(327, 229);
            this.txtFilterValues.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFilterValues.Name = "txtFilterValues";
            this.txtFilterValues.PasswordChar = '\0';
            this.txtFilterValues.PlaceholderText = "";
            this.txtFilterValues.SelectedText = "";
            this.txtFilterValues.Size = new System.Drawing.Size(236, 36);
            this.txtFilterValues.TabIndex = 3;
            this.txtFilterValues.TextChanged += new System.EventHandler(this.txtFilterValues_TextChanged);
            this.txtFilterValues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValues_KeyPress);
            // 
            // cbFiltyBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Gray;
            this.cbFilterBy.BorderRadius = 16;
            this.cbFilterBy.BorderThickness = 3;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "User Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(106, 229);
            this.cbFilterBy.Name = "cbFiltyBy";
            this.cbFilterBy.Size = new System.Drawing.Size(214, 36);
            this.cbFilterBy.StartIndex = 1;
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFitlyBy_SelectedIndexChanged);
            // 
            // cbFilterIsActive
            // 
            this.cbFilterIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterIsActive.BorderColor = System.Drawing.Color.Gray;
            this.cbFilterIsActive.BorderRadius = 16;
            this.cbFilterIsActive.BorderThickness = 3;
            this.cbFilterIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterIsActive.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.cbFilterIsActive.ForeColor = System.Drawing.Color.Black;
            this.cbFilterIsActive.ItemHeight = 30;
            this.cbFilterIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbFilterIsActive.Location = new System.Drawing.Point(327, 229);
            this.cbFilterIsActive.Name = "cbFilterIsActive";
            this.cbFilterIsActive.Size = new System.Drawing.Size(166, 36);
            this.cbFilterIsActive.StartIndex = 0;
            this.cbFilterIsActive.TabIndex = 5;
            this.cbFilterIsActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterIsActive_SelectedIndexChanged);
            // 
            // dgvListAllUsers
            // 
            this.dgvListAllUsers.AllowUserToAddRows = false;
            this.dgvListAllUsers.AllowUserToDeleteRows = false;
            this.dgvListAllUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvListAllUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvListAllUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvListAllUsers.ColumnHeadersHeight = 35;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListAllUsers.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListAllUsers.EnableHeadersVisualStyles = true;
            this.dgvListAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvListAllUsers.Location = new System.Drawing.Point(16, 283);
            this.dgvListAllUsers.Name = "dgvListAllUsers";
            this.dgvListAllUsers.ReadOnly = true;
            this.dgvListAllUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListAllUsers.RowHeadersVisible = false;
            this.dgvListAllUsers.RowHeadersWidth = 35;
            this.dgvListAllUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListAllUsers.Size = new System.Drawing.Size(974, 331);
            this.dgvListAllUsers.TabIndex = 6;
            this.dgvListAllUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgvListAllUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvListAllUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListAllUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListAllUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListAllUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvListAllUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvListAllUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListAllUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvListAllUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListAllUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListAllUsers.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvListAllUsers.ThemeStyle.ReadOnly = true;
            this.dgvListAllUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvListAllUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListAllUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvListAllUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListAllUsers.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListAllUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvListAllUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordCount.Location = new System.Drawing.Point(131, 641);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(38, 19);
            this.lblRecordCount.TabIndex = 7;
            this.lblRecordCount.Text = "[...]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "#Records";
            // 
            // cmCustomer
            // 
            this.cmCustomer.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)), true);
            this.cmCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.toolStripMenuItem2,
            this.tsmAddNewUser,
            this.toolStripMenuItem1,
            this.tsmEditUser,
            this.tsmDeleteUser,
            this.toolStripMenuItem3,
            this.sendMailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmCustomer.Name = "cmCustomer";
            this.cmCustomer.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmCustomer.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmCustomer.RenderStyle.ColorTable = null;
            this.cmCustomer.RenderStyle.RoundedEdges = true;
            this.cmCustomer.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmCustomer.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmCustomer.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmCustomer.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmCustomer.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmCustomer.Size = new System.Drawing.Size(205, 262);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Image = global::Iron.Properties.Resources.PersonDetails_32;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(204, 40);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmAddNewUser
            // 
            this.tsmAddNewUser.Image = global::Iron.Properties.Resources.Add_Person_40;
            this.tsmAddNewUser.Name = "tsmAddNewUser";
            this.tsmAddNewUser.Size = new System.Drawing.Size(204, 40);
            this.tsmAddNewUser.Text = "Add New User";
            this.tsmAddNewUser.Click += new System.EventHandler(this.tsmAddNewUser_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmEditUser
            // 
            this.tsmEditUser.Image = global::Iron.Properties.Resources.edit_32;
            this.tsmEditUser.Name = "tsmEditUser";
            this.tsmEditUser.Size = new System.Drawing.Size(204, 40);
            this.tsmEditUser.Text = "Edit";
            this.tsmEditUser.Click += new System.EventHandler(this.tsmEditUser_Click);
            // 
            // tsmDeleteUser
            // 
            this.tsmDeleteUser.Image = global::Iron.Properties.Resources.Delete_32;
            this.tsmDeleteUser.Name = "tsmDeleteUser";
            this.tsmDeleteUser.Size = new System.Drawing.Size(204, 40);
            this.tsmDeleteUser.Text = "Delete";
            this.tsmDeleteUser.Click += new System.EventHandler(this.tsmDeleteUser_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 6);
            // 
            // sendMailToolStripMenuItem
            // 
            this.sendMailToolStripMenuItem.Image = global::Iron.Properties.Resources.send_email_32;
            this.sendMailToolStripMenuItem.Name = "sendMailToolStripMenuItem";
            this.sendMailToolStripMenuItem.Size = new System.Drawing.Size(204, 40);
            this.sendMailToolStripMenuItem.Text = "Send Mail";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::Iron.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(204, 40);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 669);
            this.ContextMenuStrip = this.cmCustomer;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvListAllUsers);
            this.Controls.Add(this.cbFilterIsActive);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "frmListUsers";
            this.Text = "frmListUsers";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAllUsers)).EndInit();
            this.cmCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValues;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterIsActive;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListAllUsers;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sendMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}