namespace CodeEngine.MK.Views.Informations
{
    partial class C
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
            this.txtAboutForCustomer = new System.Windows.Forms.TextBox();
            this.txtAboutForOfficer = new System.Windows.Forms.TextBox();
            this.lblAboutForCustomer = new System.Windows.Forms.Label();
            this.lblAboutForOfficer = new System.Windows.Forms.Label();
            this.lblAboutSelect = new System.Windows.Forms.Label();
            this.cmbSelector = new System.Windows.Forms.ComboBox();
            this.lblAboutInfo = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // txtAboutForCustomer
            // 
            this.txtAboutForCustomer.Location = new System.Drawing.Point(4, 192);
            this.txtAboutForCustomer.Multiline = true;
            this.txtAboutForCustomer.Name = "txtAboutForCustomer";
            this.txtAboutForCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAboutForCustomer.Size = new System.Drawing.Size(233, 75);
            this.txtAboutForCustomer.TabIndex = 12;
            // 
            // txtAboutForOfficer
            // 
            this.txtAboutForOfficer.Location = new System.Drawing.Point(4, 93);
            this.txtAboutForOfficer.Multiline = true;
            this.txtAboutForOfficer.Name = "txtAboutForOfficer";
            this.txtAboutForOfficer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAboutForOfficer.Size = new System.Drawing.Size(233, 75);
            this.txtAboutForOfficer.TabIndex = 13;
            // 
            // lblAboutForCustomer
            // 
            this.lblAboutForCustomer.Location = new System.Drawing.Point(4, 172);
            this.lblAboutForCustomer.Name = "lblAboutForCustomer";
            this.lblAboutForCustomer.Size = new System.Drawing.Size(192, 20);
            this.lblAboutForCustomer.Text = "lblAboutForCustomer";
            // 
            // lblAboutForOfficer
            // 
            this.lblAboutForOfficer.Location = new System.Drawing.Point(4, 70);
            this.lblAboutForOfficer.Name = "lblAboutForOfficer";
            this.lblAboutForOfficer.Size = new System.Drawing.Size(135, 20);
            this.lblAboutForOfficer.Text = "lblAboutForOfficer";
            // 
            // lblAboutSelect
            // 
            this.lblAboutSelect.Location = new System.Drawing.Point(4, 22);
            this.lblAboutSelect.Name = "lblAboutSelect";
            this.lblAboutSelect.Size = new System.Drawing.Size(100, 20);
            this.lblAboutSelect.Text = "lblAboutSelect";
            // 
            // cmbSelector
            // 
            this.cmbSelector.Location = new System.Drawing.Point(4, 45);
            this.cmbSelector.Name = "cmbSelector";
            this.cmbSelector.Size = new System.Drawing.Size(233, 22);
            this.cmbSelector.TabIndex = 11;
            this.cmbSelector.SelectedIndexChanged += new System.EventHandler(this.cmbSelector_SelectedIndexChanged);
            // 
            // lblAboutInfo
            // 
            this.lblAboutInfo.Location = new System.Drawing.Point(3, 2);
            this.lblAboutInfo.Name = "lblAboutInfo";
            this.lblAboutInfo.Size = new System.Drawing.Size(100, 20);
            this.lblAboutInfo.Text = "lblAboutInfo";
            // 
            // mnu
            // 
            this.mnu.MenuItems.Add(this.mnuChangeLanguage);
            this.mnu.MenuItems.Add(this.mnuCurrentLanguage);
            // 
            // mnuChangeLanguage
            // 
            this.mnuChangeLanguage.Text = "เปลี่ยนภาษา";
            this.mnuChangeLanguage.Click += new System.EventHandler(this.mnuChangeLanguage_Click);
            // 
            // mnuCurrentLanguage
            // 
            this.mnuCurrentLanguage.Enabled = false;
            this.mnuCurrentLanguage.Text = " ";
            // 
            // InformationAboutMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtAboutForCustomer);
            this.Controls.Add(this.txtAboutForOfficer);
            this.Controls.Add(this.lblAboutForCustomer);
            this.Controls.Add(this.lblAboutForOfficer);
            this.Controls.Add(this.lblAboutSelect);
            this.Controls.Add(this.cmbSelector);
            this.Controls.Add(this.lblAboutInfo);
            this.Menu = this.mnu;
            this.Name = "InformationAboutMk";
            this.Text = "InformationAboutMk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAboutForCustomer;
        private System.Windows.Forms.TextBox txtAboutForOfficer;
        private System.Windows.Forms.Label lblAboutForCustomer;
        private System.Windows.Forms.Label lblAboutForOfficer;
        private System.Windows.Forms.Label lblAboutSelect;
        private System.Windows.Forms.ComboBox cmbSelector;
        private System.Windows.Forms.Label lblAboutInfo;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}