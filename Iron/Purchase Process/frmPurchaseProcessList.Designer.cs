namespace Iron.Purchase_Process
{
    partial class frmPurchaseProcessList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValues = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPurchaseList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordesCount = new System.Windows.Forms.Label();
            this.dtpDataFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDataTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Teko SemiBold", 30F);
            this.label1.Location = new System.Drawing.Point(457, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Purchase Process";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Iron.Properties.Resources.purchasing_process_rgb_color_icon_vector;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(467, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(315, 201);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By ";
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
            "Date Of Purchase"});
            this.cbFilterBy.Location = new System.Drawing.Point(100, 239);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(242, 36);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
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
            this.txtFilterValues.TabIndex = 4;
            this.txtFilterValues.TextChanged += new System.EventHandler(this.FilterValues_TextChanged);
            // 
            // dgvPurchaseList
            // 
            this.dgvPurchaseList.AllowUserToAddRows = false;
            this.dgvPurchaseList.AllowUserToDeleteRows = false;
            this.dgvPurchaseList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvPurchaseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPurchaseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPurchaseList.ColumnHeadersHeight = 30;
            this.dgvPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseList.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPurchaseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvPurchaseList.Location = new System.Drawing.Point(18, 303);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.ReadOnly = true;
            this.dgvPurchaseList.RowHeadersVisible = false;
            this.dgvPurchaseList.RowHeadersWidth = 30;
            this.dgvPurchaseList.Size = new System.Drawing.Size(1115, 419);
            this.dgvPurchaseList.TabIndex = 5;
            this.dgvPurchaseList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvPurchaseList.ThemeStyle.ReadOnly = true;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvPurchaseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label3.Location = new System.Drawing.Point(1, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "#Recordes";
            // 
            // lblRecordesCount
            // 
            this.lblRecordesCount.AutoSize = true;
            this.lblRecordesCount.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.lblRecordesCount.Location = new System.Drawing.Point(121, 725);
            this.lblRecordesCount.Name = "lblRecordesCount";
            this.lblRecordesCount.Size = new System.Drawing.Size(43, 31);
            this.lblRecordesCount.TabIndex = 7;
            this.lblRecordesCount.Text = "[...]";
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
            this.dtpDataFrom.TabIndex = 8;
            this.dtpDataFrom.Value = new System.DateTime(2024, 4, 22, 22, 27, 44, 513);
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
            this.dtpDataTo.TabIndex = 9;
            this.dtpDataTo.Value = new System.DateTime(2024, 4, 22, 22, 27, 44, 513);
            this.dtpDataTo.ValueChanged += new System.EventHandler(this.dtpDataTo_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.lblFrom.ForeColor = System.Drawing.Color.Coral;
            this.lblFrom.Location = new System.Drawing.Point(348, 239);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 31);
            this.lblFrom.TabIndex = 10;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.lblTo.ForeColor = System.Drawing.Color.Coral;
            this.lblTo.Location = new System.Drawing.Point(606, 239);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(32, 31);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "To";
            // 
            // frmPurchaseProcessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 765);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpDataTo);
            this.Controls.Add(this.dtpDataFrom);
            this.Controls.Add(this.lblRecordesCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPurchaseList);
            this.Controls.Add(this.txtFilterValues);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPurchaseProcessList";
            this.Text = "frmPurchaseProcessList";
            this.Load += new System.EventHandler(this.frmPurchaseProcessList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValues;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchaseList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordesCount;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
    }
}