namespace Iron.Purchase_Process
{
    partial class frmAddUpdatePurchase
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
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.tcPurchass = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpSuppliersInformation = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ctrSuppliersCardWithFilter1 = new Iron.Suppliers.Controls.ctrSuppliersCardWithFilter();
            this.tpPurchaseProcess = new System.Windows.Forms.TabPage();
            this.txtTotalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCounter = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtDateOfPurchase = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWidth = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThickness = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLisItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSubCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tcPurchass.SuspendLayout();
            this.tpSuppliersInformation.SuspendLayout();
            this.tpPurchaseProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 20;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnClose.Location = new System.Drawing.Point(521, 726);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 50);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSave.Location = new System.Drawing.Point(668, 726);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 50);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // tcPurchass
            // 
            this.tcPurchass.Controls.Add(this.tpSuppliersInformation);
            this.tcPurchass.Controls.Add(this.tpPurchaseProcess);
            this.tcPurchass.ItemSize = new System.Drawing.Size(180, 40);
            this.tcPurchass.Location = new System.Drawing.Point(9, 95);
            this.tcPurchass.Name = "tcPurchass";
            this.tcPurchass.SelectedIndex = 0;
            this.tcPurchass.Size = new System.Drawing.Size(801, 629);
            this.tcPurchass.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcPurchass.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcPurchass.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcPurchass.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcPurchass.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcPurchass.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcPurchass.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcPurchass.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcPurchass.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcPurchass.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcPurchass.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcPurchass.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcPurchass.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcPurchass.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcPurchass.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcPurchass.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcPurchass.TabIndex = 12;
            this.tcPurchass.TabMenuBackColor = System.Drawing.Color.White;
            this.tcPurchass.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpSuppliersInformation
            // 
            this.tpSuppliersInformation.Controls.Add(this.btnNext);
            this.tpSuppliersInformation.Controls.Add(this.label8);
            this.tpSuppliersInformation.Controls.Add(this.ctrSuppliersCardWithFilter1);
            this.tpSuppliersInformation.Location = new System.Drawing.Point(4, 44);
            this.tpSuppliersInformation.Name = "tpSuppliersInformation";
            this.tpSuppliersInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpSuppliersInformation.Size = new System.Drawing.Size(793, 581);
            this.tpSuppliersInformation.TabIndex = 0;
            this.tpSuppliersInformation.Text = "Suppliers Information";
            this.tpSuppliersInformation.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 20;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.LightGreen;
            this.btnNext.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNext.Location = new System.Drawing.Point(640, 525);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 20F);
            this.label8.Location = new System.Drawing.Point(288, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "Find a Suppliers";
            // 
            // ctrSuppliersCardWithFilter1
            // 
            this.ctrSuppliersCardWithFilter1.FilterEnabled = true;
            this.ctrSuppliersCardWithFilter1.Location = new System.Drawing.Point(9, 59);
            this.ctrSuppliersCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrSuppliersCardWithFilter1.Name = "ctrSuppliersCardWithFilter1";
            this.ctrSuppliersCardWithFilter1.ShowAddPerson = true;
            this.ctrSuppliersCardWithFilter1.Size = new System.Drawing.Size(779, 458);
            this.ctrSuppliersCardWithFilter1.TabIndex = 0;
            // 
            // tpPurchaseProcess
            // 
            this.tpPurchaseProcess.Controls.Add(this.cbSubCategory);
            this.tpPurchaseProcess.Controls.Add(this.label4);
            this.tpPurchaseProcess.Controls.Add(this.txtTotalAmount);
            this.tpPurchaseProcess.Controls.Add(this.label9);
            this.tpPurchaseProcess.Controls.Add(this.label10);
            this.tpPurchaseProcess.Controls.Add(this.nudCounter);
            this.tpPurchaseProcess.Controls.Add(this.txtDateOfPurchase);
            this.tpPurchaseProcess.Controls.Add(this.txtPrice);
            this.tpPurchaseProcess.Controls.Add(this.txtWidth);
            this.tpPurchaseProcess.Controls.Add(this.txtWeight);
            this.tpPurchaseProcess.Controls.Add(this.label7);
            this.tpPurchaseProcess.Controls.Add(this.label6);
            this.tpPurchaseProcess.Controls.Add(this.label5);
            this.tpPurchaseProcess.Controls.Add(this.label3);
            this.tpPurchaseProcess.Controls.Add(this.label2);
            this.tpPurchaseProcess.Controls.Add(this.txtThickness);
            this.tpPurchaseProcess.Controls.Add(this.cbLisItems);
            this.tpPurchaseProcess.Controls.Add(this.label1);
            this.tpPurchaseProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpPurchaseProcess.Location = new System.Drawing.Point(4, 44);
            this.tpPurchaseProcess.Name = "tpPurchaseProcess";
            this.tpPurchaseProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tpPurchaseProcess.Size = new System.Drawing.Size(793, 581);
            this.tpPurchaseProcess.TabIndex = 1;
            this.tpPurchaseProcess.Text = "Purchase Process";
            this.tpPurchaseProcess.UseVisualStyleBackColor = true;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTotalAmount.BorderRadius = 15;
            this.txtTotalAmount.BorderThickness = 2;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.DefaultText = "";
            this.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(581, 470);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PlaceholderText = "";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(194, 41);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label9.Location = new System.Drawing.Point(407, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 31);
            this.label9.TabIndex = 32;
            this.label9.Text = "Total Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label10.Location = new System.Drawing.Point(407, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 31);
            this.label10.TabIndex = 31;
            this.label10.Text = "Quantity";
            // 
            // nudCounter
            // 
            this.nudCounter.BackColor = System.Drawing.Color.Transparent;
            this.nudCounter.BorderColor = System.Drawing.Color.RoyalBlue;
            this.nudCounter.BorderRadius = 15;
            this.nudCounter.BorderThickness = 2;
            this.nudCounter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCounter.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCounter.Location = new System.Drawing.Point(581, 360);
            this.nudCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCounter.Name = "nudCounter";
            this.nudCounter.Size = new System.Drawing.Size(144, 46);
            this.nudCounter.TabIndex = 7;
            this.nudCounter.ValueChanged += new System.EventHandler(this.nudCounter_ValueChanged);
            // 
            // txtDateOfPurchase
            // 
            this.txtDateOfPurchase.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtDateOfPurchase.BorderRadius = 15;
            this.txtDateOfPurchase.BorderThickness = 2;
            this.txtDateOfPurchase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateOfPurchase.DefaultText = "";
            this.txtDateOfPurchase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDateOfPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDateOfPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateOfPurchase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateOfPurchase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateOfPurchase.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOfPurchase.ForeColor = System.Drawing.Color.Black;
            this.txtDateOfPurchase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateOfPurchase.Location = new System.Drawing.Point(169, 360);
            this.txtDateOfPurchase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDateOfPurchase.Name = "txtDateOfPurchase";
            this.txtDateOfPurchase.PasswordChar = '\0';
            this.txtDateOfPurchase.PlaceholderText = "";
            this.txtDateOfPurchase.ReadOnly = true;
            this.txtDateOfPurchase.SelectedText = "";
            this.txtDateOfPurchase.Size = new System.Drawing.Size(225, 44);
            this.txtDateOfPurchase.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtPrice.BorderRadius = 15;
            this.txtPrice.BorderThickness = 2;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(581, 247);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(144, 41);
            this.txtPrice.TabIndex = 5;
            // 
            // txtWidth
            // 
            this.txtWidth.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtWidth.BorderRadius = 15;
            this.txtWidth.BorderThickness = 2;
            this.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth.DefaultText = "";
            this.txtWidth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWidth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWidth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWidth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWidth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWidth.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.ForeColor = System.Drawing.Color.Black;
            this.txtWidth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWidth.Location = new System.Drawing.Point(581, 145);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.PlaceholderText = "";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.SelectedText = "";
            this.txtWidth.Size = new System.Drawing.Size(144, 41);
            this.txtWidth.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtWeight.BorderRadius = 15;
            this.txtWeight.BorderThickness = 2;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Black;
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Location = new System.Drawing.Point(169, 247);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.SelectedText = "";
            this.txtWeight.Size = new System.Drawing.Size(144, 41);
            this.txtWeight.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label7.Location = new System.Drawing.Point(18, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Thickness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label6.Location = new System.Drawing.Point(18, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label5.Location = new System.Drawing.Point(407, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label3.Location = new System.Drawing.Point(407, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label2.Location = new System.Drawing.Point(18, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date Of Purchase";
            // 
            // txtThickness
            // 
            this.txtThickness.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtThickness.BorderRadius = 15;
            this.txtThickness.BorderThickness = 2;
            this.txtThickness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThickness.DefaultText = "";
            this.txtThickness.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThickness.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThickness.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThickness.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThickness.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThickness.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThickness.ForeColor = System.Drawing.Color.Black;
            this.txtThickness.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThickness.Location = new System.Drawing.Point(169, 142);
            this.txtThickness.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.PasswordChar = '\0';
            this.txtThickness.PlaceholderText = "";
            this.txtThickness.ReadOnly = true;
            this.txtThickness.SelectedText = "";
            this.txtThickness.Size = new System.Drawing.Size(144, 41);
            this.txtThickness.TabIndex = 2;
            // 
            // cbLisItems
            // 
            this.cbLisItems.BackColor = System.Drawing.Color.Transparent;
            this.cbLisItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbLisItems.BorderRadius = 15;
            this.cbLisItems.BorderThickness = 3;
            this.cbLisItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLisItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLisItems.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbLisItems.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLisItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLisItems.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbLisItems.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbLisItems.ItemHeight = 30;
            this.cbLisItems.Location = new System.Drawing.Point(169, 40);
            this.cbLisItems.Name = "cbLisItems";
            this.cbLisItems.ShadowDecoration.Color = System.Drawing.Color.Coral;
            this.cbLisItems.Size = new System.Drawing.Size(202, 36);
            this.cbLisItems.TabIndex = 1;
            this.cbLisItems.SelectedIndexChanged += new System.EventHandler(this.cbLisItems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Item Type";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Algerian", 30F);
            this.lbltitle.ForeColor = System.Drawing.Color.Coral;
            this.lbltitle.Location = new System.Drawing.Point(116, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(485, 45);
            this.lbltitle.TabIndex = 11;
            this.lbltitle.Text = "New Purchase Process";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbSubCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbSubCategory.BorderRadius = 15;
            this.cbSubCategory.BorderThickness = 3;
            this.cbSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategory.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbSubCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubCategory.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbSubCategory.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbSubCategory.ItemHeight = 30;
            this.cbSubCategory.Location = new System.Drawing.Point(488, 40);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.ShadowDecoration.Color = System.Drawing.Color.Coral;
            this.cbSubCategory.Size = new System.Drawing.Size(277, 36);
            this.cbSubCategory.TabIndex = 33;
            this.cbSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbSubCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Teko SemiBold", 16F);
            this.label4.Location = new System.Drawing.Point(400, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sub Item";
            // 
            // frmAddUpdatePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 792);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcPurchass);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmAddUpdatePurchase";
            this.Text = "frmAddUpdatePurchase";
            this.Load += new System.EventHandler(this.frmAddUpdatePurchase_Load);
            this.tcPurchass.ResumeLayout(false);
            this.tpSuppliersInformation.ResumeLayout(false);
            this.tpSuppliersInformation.PerformLayout();
            this.tpPurchaseProcess.ResumeLayout(false);
            this.tpPurchaseProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSave;
        private Guna.UI2.WinForms.Guna2TabControl tcPurchass;
        private System.Windows.Forms.TabPage tpSuppliersInformation;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnNext;
        private System.Windows.Forms.Label label8;
        private Suppliers.Controls.ctrSuppliersCardWithFilter ctrSuppliersCardWithFilter1;
        private System.Windows.Forms.TabPage tpPurchaseProcess;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCounter;
        private Guna.UI2.WinForms.Guna2TextBox txtDateOfPurchase;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtWidth;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtThickness;
        private Guna.UI2.WinForms.Guna2ComboBox cbLisItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubCategory;
        private System.Windows.Forms.Label label4;
    }
}