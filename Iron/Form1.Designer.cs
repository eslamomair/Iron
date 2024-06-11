namespace Iron
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewSubCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListOfItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustoumer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFindCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateCusromer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowAllCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFindSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteSupplers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowAllSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.المبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewSale = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewAllSeiling = new System.Windows.Forms.ToolStripMenuItem();
            this.المشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewpureses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowAllPurchese = new System.Windows.Forms.ToolStripMenuItem();
            this.المصروفاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المخزنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListAllUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmChanindPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيهToolStripMenuItem,
            this.tsmCustoumer,
            this.الموردينToolStripMenuItem,
            this.المبيعاتToolStripMenuItem,
            this.المشترياتToolStripMenuItem,
            this.المصروفاتToolStripMenuItem,
            this.المخزنToolStripMenuItem,
            this.tsmLogOut,
            this.tsmUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1404, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيهToolStripMenuItem
            // 
            this.الرئيسيهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNewSubCategory,
            this.tsmListOfItems});
            this.الرئيسيهToolStripMenuItem.Image = global::Iron.Properties.Resources.Application_Types_64;
            this.الرئيسيهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.الرئيسيهToolStripMenuItem.Name = "الرئيسيهToolStripMenuItem";
            this.الرئيسيهToolStripMenuItem.Size = new System.Drawing.Size(137, 68);
            this.الرئيسيهToolStripMenuItem.Text = "الرئيسيه";
            // 
            // tsmAddNewSubCategory
            // 
            this.tsmAddNewSubCategory.Name = "tsmAddNewSubCategory";
            this.tsmAddNewSubCategory.Size = new System.Drawing.Size(174, 26);
            this.tsmAddNewSubCategory.Text = "اضافه صنف";
            this.tsmAddNewSubCategory.Click += new System.EventHandler(this.tsmAddNewSubCategory_Click);
            // 
            // tsmListOfItems
            // 
            this.tsmListOfItems.Name = "tsmListOfItems";
            this.tsmListOfItems.Size = new System.Drawing.Size(174, 26);
            this.tsmListOfItems.Text = "عرض الاصناف";
            this.tsmListOfItems.Click += new System.EventHandler(this.tsmListOfItems_Click);
            // 
            // tsmCustoumer
            // 
            this.tsmCustoumer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFindCustomer,
            this.tsmAddNewCustomer,
            this.tsmUpdateCusromer,
            this.tsmDeleteCustomer,
            this.tsmShowAllCustomer});
            this.tsmCustoumer.Image = global::Iron.Properties.Resources.People_64;
            this.tsmCustoumer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCustoumer.Name = "tsmCustoumer";
            this.tsmCustoumer.Size = new System.Drawing.Size(129, 68);
            this.tsmCustoumer.Text = "العملاء";
            // 
            // tsmFindCustomer
            // 
            this.tsmFindCustomer.Name = "tsmFindCustomer";
            this.tsmFindCustomer.Size = new System.Drawing.Size(198, 26);
            this.tsmFindCustomer.Text = "بحث عن عميل ";
            this.tsmFindCustomer.Click += new System.EventHandler(this.tsmFindCustomer_Click);
            // 
            // tsmAddNewCustomer
            // 
            this.tsmAddNewCustomer.Name = "tsmAddNewCustomer";
            this.tsmAddNewCustomer.Size = new System.Drawing.Size(198, 26);
            this.tsmAddNewCustomer.Text = "اضافه عميل ";
            this.tsmAddNewCustomer.Click += new System.EventHandler(this.tsmAddNewCustomer_Click);
            // 
            // tsmUpdateCusromer
            // 
            this.tsmUpdateCusromer.Name = "tsmUpdateCusromer";
            this.tsmUpdateCusromer.Size = new System.Drawing.Size(198, 26);
            this.tsmUpdateCusromer.Text = "تعديل بيانات عميل";
            this.tsmUpdateCusromer.Click += new System.EventHandler(this.tsmUpdateCustomer_Click);
            // 
            // tsmDeleteCustomer
            // 
            this.tsmDeleteCustomer.Name = "tsmDeleteCustomer";
            this.tsmDeleteCustomer.Size = new System.Drawing.Size(198, 26);
            this.tsmDeleteCustomer.Text = "حذف عميل ";
            // 
            // tsmShowAllCustomer
            // 
            this.tsmShowAllCustomer.Name = "tsmShowAllCustomer";
            this.tsmShowAllCustomer.Size = new System.Drawing.Size(198, 26);
            this.tsmShowAllCustomer.Text = "عرض كل العملاء";
            this.tsmShowAllCustomer.Click += new System.EventHandler(this.tsmShowAllCustomer_Click);
            // 
            // الموردينToolStripMenuItem
            // 
            this.الموردينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFindSuppliers,
            this.tsmAddNewSuppliers,
            this.tsmUpdateSuppliers,
            this.tsmDeleteSupplers,
            this.tsmShowAllSuppliers});
            this.الموردينToolStripMenuItem.Image = global::Iron.Properties.Resources.users_64;
            this.الموردينToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.الموردينToolStripMenuItem.Name = "الموردينToolStripMenuItem";
            this.الموردينToolStripMenuItem.Size = new System.Drawing.Size(142, 68);
            this.الموردينToolStripMenuItem.Text = "الموردين";
            // 
            // tsmFindSuppliers
            // 
            this.tsmFindSuppliers.Name = "tsmFindSuppliers";
            this.tsmFindSuppliers.Size = new System.Drawing.Size(199, 26);
            this.tsmFindSuppliers.Text = "بحث عن مورد";
            this.tsmFindSuppliers.Click += new System.EventHandler(this.tsmFindSuppliers_Click);
            // 
            // tsmAddNewSuppliers
            // 
            this.tsmAddNewSuppliers.Name = "tsmAddNewSuppliers";
            this.tsmAddNewSuppliers.Size = new System.Drawing.Size(199, 26);
            this.tsmAddNewSuppliers.Text = "اضافه مورد";
            this.tsmAddNewSuppliers.Click += new System.EventHandler(this.tsmAddNewSuppliers_Click);
            // 
            // tsmUpdateSuppliers
            // 
            this.tsmUpdateSuppliers.Name = "tsmUpdateSuppliers";
            this.tsmUpdateSuppliers.Size = new System.Drawing.Size(199, 26);
            this.tsmUpdateSuppliers.Text = "تعديل بيانات مورد";
            // 
            // tsmDeleteSupplers
            // 
            this.tsmDeleteSupplers.Name = "tsmDeleteSupplers";
            this.tsmDeleteSupplers.Size = new System.Drawing.Size(199, 26);
            this.tsmDeleteSupplers.Text = "حذف مورد";
            // 
            // tsmShowAllSuppliers
            // 
            this.tsmShowAllSuppliers.Name = "tsmShowAllSuppliers";
            this.tsmShowAllSuppliers.Size = new System.Drawing.Size(199, 26);
            this.tsmShowAllSuppliers.Text = "عرض كل الموردين";
            this.tsmShowAllSuppliers.Click += new System.EventHandler(this.tsmShowAllSuppliers_Click);
            // 
            // المبيعاتToolStripMenuItem
            // 
            this.المبيعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewSale,
            this.tsmViewAllSeiling});
            this.المبيعاتToolStripMenuItem.Image = global::Iron.Properties.Resources.People_64;
            this.المبيعاتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.المبيعاتToolStripMenuItem.Name = "المبيعاتToolStripMenuItem";
            this.المبيعاتToolStripMenuItem.Size = new System.Drawing.Size(142, 68);
            this.المبيعاتToolStripMenuItem.Text = "المبيعات";
            // 
            // tsmNewSale
            // 
            this.tsmNewSale.Name = "tsmNewSale";
            this.tsmNewSale.Size = new System.Drawing.Size(203, 26);
            this.tsmNewSale.Text = "عمليه بيع جديده";
            this.tsmNewSale.Click += new System.EventHandler(this.tsmNewSale_Click);
            // 
            // tsmViewAllSeiling
            // 
            this.tsmViewAllSeiling.Name = "tsmViewAllSeiling";
            this.tsmViewAllSeiling.Size = new System.Drawing.Size(203, 26);
            this.tsmViewAllSeiling.Text = "عرض علميات البيع ";
            this.tsmViewAllSeiling.Click += new System.EventHandler(this.tsmViewAllSailing_Click);
            // 
            // المشترياتToolStripMenuItem
            // 
            this.المشترياتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewpureses,
            this.tsmShowAllPurchese});
            this.المشترياتToolStripMenuItem.Image = global::Iron.Properties.Resources.users_64;
            this.المشترياتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.المشترياتToolStripMenuItem.Name = "المشترياتToolStripMenuItem";
            this.المشترياتToolStripMenuItem.Size = new System.Drawing.Size(154, 68);
            this.المشترياتToolStripMenuItem.Text = "المشتريات";
            // 
            // tsmNewpureses
            // 
            this.tsmNewpureses.Name = "tsmNewpureses";
            this.tsmNewpureses.Size = new System.Drawing.Size(209, 26);
            this.tsmNewpureses.Text = "عمليه شراء جديده";
            this.tsmNewpureses.Click += new System.EventHandler(this.tsmNewPurchase_Click);
            // 
            // tsmShowAllPurchese
            // 
            this.tsmShowAllPurchese.Name = "tsmShowAllPurchese";
            this.tsmShowAllPurchese.Size = new System.Drawing.Size(209, 26);
            this.tsmShowAllPurchese.Text = "عرض عمليات الشراء";
            this.tsmShowAllPurchese.Click += new System.EventHandler(this.tsmShowAllPurchase_Click);
            // 
            // المصروفاتToolStripMenuItem
            // 
            this.المصروفاتToolStripMenuItem.Name = "المصروفاتToolStripMenuItem";
            this.المصروفاتToolStripMenuItem.Size = new System.Drawing.Size(96, 68);
            this.المصروفاتToolStripMenuItem.Text = "المصروفات";
            // 
            // المخزنToolStripMenuItem
            // 
            this.المخزنToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaa});
            this.المخزنToolStripMenuItem.Name = "المخزنToolStripMenuItem";
            this.المخزنToolStripMenuItem.Size = new System.Drawing.Size(67, 68);
            this.المخزنToolStripMenuItem.Text = "المخزن";
            // 
            // aaa
            // 
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(160, 26);
            this.aaa.Text = "اضافه عنصر";
            // 
            // tsmLogOut
            // 
            this.tsmLogOut.Name = "tsmLogOut";
            this.tsmLogOut.Size = new System.Drawing.Size(111, 68);
            this.tsmLogOut.Text = "تسجيل الخروج";
            this.tsmLogOut.Click += new System.EventHandler(this.tsmLogOut_Click);
            // 
            // tsmUsers
            // 
            this.tsmUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddNewUsers,
            this.tsmListAllUsers,
            this.toolStripMenuItem1,
            this.tsmChanindPassword});
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(100, 68);
            this.tsmUsers.Text = "المستخدمين";
            // 
            // tsmAddNewUsers
            // 
            this.tsmAddNewUsers.Name = "tsmAddNewUsers";
            this.tsmAddNewUsers.Size = new System.Drawing.Size(221, 26);
            this.tsmAddNewUsers.Text = "اضافه مستخدم ";
            this.tsmAddNewUsers.Click += new System.EventHandler(this.tsmAddNewUsers_Click);
            // 
            // tsmListAllUsers
            // 
            this.tsmListAllUsers.Name = "tsmListAllUsers";
            this.tsmListAllUsers.Size = new System.Drawing.Size(221, 26);
            this.tsmListAllUsers.Text = "عرض كل المستخدمين";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 6);
            // 
            // tsmChanindPassword
            // 
            this.tsmChanindPassword.Name = "tsmChanindPassword";
            this.tsmChanindPassword.Size = new System.Drawing.Size(221, 26);
            this.tsmChanindPassword.Text = "تغير كلمه المرور";
            this.tsmChanindPassword.Click += new System.EventHandler(this.tsmChanindPassword_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Salmon;
            this.guna2PictureBox1.Image = global::Iron.Properties.Resources._4;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 72);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1404, 633);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 705);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCustoumer;
        private System.Windows.Forms.ToolStripMenuItem الموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المشترياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المصروفاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المخزنToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmFindCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateCusromer;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmShowAllCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmFindSuppliers;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewSuppliers;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateSuppliers;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteSupplers;
        private System.Windows.Forms.ToolStripMenuItem tsmShowAllSuppliers;
        private System.Windows.Forms.ToolStripMenuItem tsmLogOut;
        private System.Windows.Forms.ToolStripMenuItem aaa;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewSubCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmListOfItems;
        private System.Windows.Forms.ToolStripMenuItem tsmNewpureses;
        private System.Windows.Forms.ToolStripMenuItem tsmShowAllPurchese;
        private System.Windows.Forms.ToolStripMenuItem tsmNewSale;
        private System.Windows.Forms.ToolStripMenuItem tsmViewAllSeiling;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmListAllUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmChanindPassword;
    }
}

