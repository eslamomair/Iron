namespace Iron.Selling_Process
{
    partial class frmListAllSailingProcess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpDataTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDataFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblRecordesCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSleingList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtFilterValues = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSleingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.lblTo.ForeColor = System.Drawing.Color.Coral;
            this.lblTo.Location = new System.Drawing.Point(606, 239);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(32, 31);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.lblFrom.ForeColor = System.Drawing.Color.Coral;
            this.lblFrom.Location = new System.Drawing.Point(348, 239);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 31);
            this.lblFrom.TabIndex = 22;
            this.lblFrom.Text = "From";
            // 
            // dtpDataTo
            // 
            this.dtpDataTo.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.dtpDataTo.BorderRadius = 15;
            this.dtpDataTo.BorderThickness = 3;
            this.dtpDataTo.Checked = true;
            this.dtpDataTo.FillColor = System.Drawing.Color.White;
            this.dtpDataTo.FocusedColor = System.Drawing.Color.Blue;
            this.dtpDataTo.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpDataTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTo.Location = new System.Drawing.Point(660, 239);
            this.dtpDataTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDataTo.Name = "dtpDataTo";
            this.dtpDataTo.Size = new System.Drawing.Size(187, 36);
            this.dtpDataTo.TabIndex = 21;
            this.dtpDataTo.Value = new System.DateTime(2024, 4, 22, 22, 27, 44, 513);
            this.dtpDataTo.ValueChanged += new System.EventHandler(this.dtpDataTo_ValueChanged);
            // 
            // dtpDataFrom
            // 
            this.dtpDataFrom.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.dtpDataFrom.BorderRadius = 15;
            this.dtpDataFrom.BorderThickness = 3;
            this.dtpDataFrom.Checked = true;
            this.dtpDataFrom.FillColor = System.Drawing.Color.White;
            this.dtpDataFrom.FocusedColor = System.Drawing.Color.Blue;
            this.dtpDataFrom.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFrom.Location = new System.Drawing.Point(417, 239);
            this.dtpDataFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDataFrom.Name = "dtpDataFrom";
            this.dtpDataFrom.Size = new System.Drawing.Size(183, 36);
            this.dtpDataFrom.TabIndex = 20;
            this.dtpDataFrom.Value = new System.DateTime(2024, 4, 22, 22, 27, 44, 513);
            // 
            // lblRecordesCount
            // 
            this.lblRecordesCount.AutoSize = true;
            this.lblRecordesCount.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.lblRecordesCount.Location = new System.Drawing.Point(121, 725);
            this.lblRecordesCount.Name = "lblRecordesCount";
            this.lblRecordesCount.Size = new System.Drawing.Size(43, 31);
            this.lblRecordesCount.TabIndex = 19;
            this.lblRecordesCount.Text = "[...]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label3.Location = new System.Drawing.Point(1, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "#Recordes";
            // 
            // dgvSleingList
            // 
            this.dgvSleingList.AllowUserToAddRows = false;
            this.dgvSleingList.AllowUserToDeleteRows = false;
            this.dgvSleingList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvSleingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSleingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSleingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSleingList.ColumnHeadersHeight = 30;
            this.dgvSleingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSleingList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSleingList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvSleingList.Location = new System.Drawing.Point(18, 303);
            this.dgvSleingList.Name = "dgvSleingList";
            this.dgvSleingList.ReadOnly = true;
            this.dgvSleingList.RowHeadersVisible = false;
            this.dgvSleingList.RowHeadersWidth = 30;
            this.dgvSleingList.Size = new System.Drawing.Size(1115, 419);
            this.dgvSleingList.TabIndex = 17;
            this.dgvSleingList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvSleingList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvSleingList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSleingList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSleingList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSleingList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSleingList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSleingList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvSleingList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvSleingList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSleingList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvSleingList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSleingList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSleingList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvSleingList.ThemeStyle.ReadOnly = true;
            this.dgvSleingList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvSleingList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSleingList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvSleingList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSleingList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSleingList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvSleingList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtFilterValues
            // 
            this.txtFilterValues.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFilterValues.BorderRadius = 15;
            this.txtFilterValues.BorderThickness = 2;
            this.txtFilterValues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValues.DefaultText = "";
            this.txtFilterValues.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValues.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValues.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValues.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValues.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValues.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValues.Location = new System.Drawing.Point(367, 239);
            this.txtFilterValues.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFilterValues.Name = "txtFilterValues";
            this.txtFilterValues.PasswordChar = '\0';
            this.txtFilterValues.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFilterValues.PlaceholderText = "";
            this.txtFilterValues.SelectedText = "";
            this.txtFilterValues.Size = new System.Drawing.Size(286, 36);
            this.txtFilterValues.TabIndex = 16;
            this.txtFilterValues.TextChanged += new System.EventHandler(this.txtFilterValues_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Cyan;
            this.cbFilterBy.BorderRadius = 15;
            this.cbFilterBy.BorderThickness = 2;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "Name",
            "Categories",
            "Sub Categories",
            "Thickness",
            "Weight",
            "Width",
            "Quantity",
            "Price",
            "Date Of Sale"});
            this.cbFilterBy.Location = new System.Drawing.Point(100, 239);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(242, 36);
            this.cbFilterBy.TabIndex = 15;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter By ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Teko SemiBold", 30F);
            this.label1.Location = new System.Drawing.Point(381, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "List Sailing Process";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Iron.Properties.Resources.purchasing_process_rgb_color_icon_vector;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(367, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(315, 201);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmListAllSailingProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 766);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpDataTo);
            this.Controls.Add(this.dtpDataFrom);
            this.Controls.Add(this.lblRecordesCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSleingList);
            this.Controls.Add(this.txtFilterValues);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "frmListAllSailingProcess";
            this.Text = "frmListAllSaleingProcess";
            this.Load += new System.EventHandler(this.frmListAllSailingProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSleingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFrom;
        private System.Windows.Forms.Label lblRecordesCount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSleingList;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValues;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}