namespace Iron.Customers.Control
{
    partial class ctrCustomerCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ctrCustomerCard1 = new Iron.Customers.Control.ctrCustomerCard();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSarch = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFilter
            // 
            this.gpFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gpFilter.BorderRadius = 20;
            this.gpFilter.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gpFilter.BorderThickness = 10;
            this.gpFilter.Controls.Add(this.btnAddNewCustomer);
            this.gpFilter.Controls.Add(this.btnSarch);
            this.gpFilter.Controls.Add(this.txtFilterValue);
            this.gpFilter.Controls.Add(this.label1);
            this.gpFilter.Controls.Add(this.cbFilterBy);
            this.gpFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gpFilter.CustomBorderThickness = new System.Windows.Forms.Padding(7, 40, 7, 7);
            this.gpFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFilter.ForeColor = System.Drawing.Color.SlateBlue;
            this.gpFilter.Location = new System.Drawing.Point(2, 3);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(774, 104);
            this.gpFilter.TabIndex = 0;
            this.gpFilter.Text = "Filter";
            // 
            // ctrCustomerCard1
            // 
            this.ctrCustomerCard1.Location = new System.Drawing.Point(1, 108);
            this.ctrCustomerCard1.Name = "ctrCustomerCard1";
            this.ctrCustomerCard1.Size = new System.Drawing.Size(775, 350);
            this.ctrCustomerCard1.TabIndex = 1;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Blue;
            this.cbFilterBy.BorderRadius = 15;
            this.cbFilterBy.BorderThickness = 2;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Customer ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(121, 47);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(199, 36);
            this.cbFilterBy.TabIndex = 0;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By :";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderColor = System.Drawing.Color.Blue;
            this.txtFilterValue.BorderRadius = 15;
            this.txtFilterValue.BorderThickness = 2;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(327, 47);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(197, 36);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // btnSarch
            // 
            this.btnSarch.BorderColor = System.Drawing.Color.Peru;
            this.btnSarch.BorderRadius = 15;
            this.btnSarch.BorderThickness = 2;
            this.btnSarch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSarch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSarch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSarch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSarch.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSarch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSarch.ForeColor = System.Drawing.Color.White;
            this.btnSarch.Image = global::Iron.Properties.Resources.SearchPerson;
            this.btnSarch.Location = new System.Drawing.Point(531, 47);
            this.btnSarch.Name = "btnSarch";
            this.btnSarch.Size = new System.Drawing.Size(59, 40);
            this.btnSarch.TabIndex = 3;
            this.btnSarch.Click += new System.EventHandler(this.btnSarch_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BorderColor = System.Drawing.Color.LightSalmon;
            this.btnAddNewCustomer.BorderRadius = 15;
            this.btnAddNewCustomer.BorderThickness = 2;
            this.btnAddNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCustomer.FillColor = System.Drawing.Color.Lime;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Image = global::Iron.Properties.Resources.Add_Person_40;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(606, 47);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.PressedColor = System.Drawing.Color.LightCoral;
            this.btnAddNewCustomer.Size = new System.Drawing.Size(59, 40);
            this.btnAddNewCustomer.TabIndex = 4;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrCustomerCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrCustomerCard1);
            this.Controls.Add(this.gpFilter);
            this.Name = "ctrCustomerCardWithFilter";
            this.Size = new System.Drawing.Size(773, 457);
            this.Load += new System.EventHandler(this.ctrCustomerCardWithFilter_Load);
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gpFilter;
        private ctrCustomerCard ctrCustomerCard1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private Guna.UI2.WinForms.Guna2Button btnSarch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
