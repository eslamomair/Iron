namespace Iron.Users.Control
{
    partial class ctrUserCard
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
            this.ctrPersonCard1 = new Iron.People.ctrPersonCard();
            this.gpUserLoginInformation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUseName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.gpUserLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrPersonCard1
            // 
            this.ctrPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrPersonCard1.Name = "ctrPersonCard1";
            this.ctrPersonCard1.Size = new System.Drawing.Size(773, 348);
            this.ctrPersonCard1.TabIndex = 0;
            // 
            // gpUserLoginInformation
            // 
            this.gpUserLoginInformation.BorderRadius = 20;
            this.gpUserLoginInformation.BorderThickness = 5;
            this.gpUserLoginInformation.Controls.Add(this.label6);
            this.gpUserLoginInformation.Controls.Add(this.lblIsActive);
            this.gpUserLoginInformation.Controls.Add(this.label4);
            this.gpUserLoginInformation.Controls.Add(this.lblUseName);
            this.gpUserLoginInformation.Controls.Add(this.label3);
            this.gpUserLoginInformation.Controls.Add(this.lblUserID);
            this.gpUserLoginInformation.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.gpUserLoginInformation.Font = new System.Drawing.Font("Segoe Print", 14F);
            this.gpUserLoginInformation.ForeColor = System.Drawing.Color.Blue;
            this.gpUserLoginInformation.Location = new System.Drawing.Point(3, 355);
            this.gpUserLoginInformation.Name = "gpUserLoginInformation";
            this.gpUserLoginInformation.ShadowDecoration.BorderRadius = 12;
            this.gpUserLoginInformation.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.gpUserLoginInformation.Size = new System.Drawing.Size(773, 96);
            this.gpUserLoginInformation.TabIndex = 1;
            this.gpUserLoginInformation.Text = "Login Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label6.Location = new System.Drawing.Point(567, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Is Active";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe Print", 14F);
            this.lblIsActive.ForeColor = System.Drawing.Color.Navy;
            this.lblIsActive.Location = new System.Drawing.Point(644, 44);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(46, 33);
            this.lblIsActive.TabIndex = 5;
            this.lblIsActive.Text = "[...]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label4.Location = new System.Drawing.Point(328, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "User Name";
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.Font = new System.Drawing.Font("Segoe Print", 14F);
            this.lblUseName.ForeColor = System.Drawing.Color.Navy;
            this.lblUseName.Location = new System.Drawing.Point(433, 43);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(46, 33);
            this.lblUseName.TabIndex = 3;
            this.lblUseName.Text = "[...]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label3.Location = new System.Drawing.Point(96, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe Print", 14F);
            this.lblUserID.ForeColor = System.Drawing.Color.Navy;
            this.lblUserID.Location = new System.Drawing.Point(173, 43);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(46, 33);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "[...]";
            // 
            // ctrUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpUserLoginInformation);
            this.Controls.Add(this.ctrPersonCard1);
            this.Name = "ctrUserCard";
            this.Size = new System.Drawing.Size(781, 456);
            this.gpUserLoginInformation.ResumeLayout(false);
            this.gpUserLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.ctrPersonCard ctrPersonCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gpUserLoginInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserID;
    }
}
