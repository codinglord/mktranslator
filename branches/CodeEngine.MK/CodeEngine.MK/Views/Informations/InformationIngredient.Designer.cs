namespace CodeEngine.MK.Views.Informations
{
    partial class InformationIngredient
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
            this.lblIngredientInfo = new System.Windows.Forms.Label();
            this.cmbIngredient = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblIngredientForOfficer = new System.Windows.Forms.Label();
            this.lblIngredientForCustomer = new System.Windows.Forms.Label();
            this.txtIngridentOfficer = new System.Windows.Forms.TextBox();
            this.txtIngredientForCustomer = new System.Windows.Forms.TextBox();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // lblIngredientInfo
            // 
            this.lblIngredientInfo.Location = new System.Drawing.Point(3, 0);
            this.lblIngredientInfo.Name = "lblIngredientInfo";
            this.lblIngredientInfo.Size = new System.Drawing.Size(100, 20);
            this.lblIngredientInfo.Text = "lblIngredientInfo";
            // 
            // cmbIngredient
            // 
            this.cmbIngredient.Location = new System.Drawing.Point(4, 43);
            this.cmbIngredient.Name = "cmbIngredient";
            this.cmbIngredient.Size = new System.Drawing.Size(233, 22);
            this.cmbIngredient.TabIndex = 2;
            this.cmbIngredient.SelectedIndexChanged += new System.EventHandler(this.cmbIngredient_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(4, 20);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(100, 20);
            this.lblSelect.Text = "lblSelect";
            // 
            // lblIngredientForOfficer
            // 
            this.lblIngredientForOfficer.Location = new System.Drawing.Point(4, 68);
            this.lblIngredientForOfficer.Name = "lblIngredientForOfficer";
            this.lblIngredientForOfficer.Size = new System.Drawing.Size(135, 20);
            this.lblIngredientForOfficer.Text = "lblIngredientForOfficer";
            // 
            // lblIngredientForCustomer
            // 
            this.lblIngredientForCustomer.Location = new System.Drawing.Point(4, 170);
            this.lblIngredientForCustomer.Name = "lblIngredientForCustomer";
            this.lblIngredientForCustomer.Size = new System.Drawing.Size(192, 20);
            this.lblIngredientForCustomer.Text = "lblIngredientForCustomer";
            // 
            // txtIngridentOfficer
            // 
            this.txtIngridentOfficer.Location = new System.Drawing.Point(4, 91);
            this.txtIngridentOfficer.Multiline = true;
            this.txtIngridentOfficer.Name = "txtIngridentOfficer";
            this.txtIngridentOfficer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIngridentOfficer.Size = new System.Drawing.Size(233, 75);
            this.txtIngridentOfficer.TabIndex = 6;
            // 
            // txtIngredientForCustomer
            // 
            this.txtIngredientForCustomer.Location = new System.Drawing.Point(4, 190);
            this.txtIngredientForCustomer.Multiline = true;
            this.txtIngredientForCustomer.Name = "txtIngredientForCustomer";
            this.txtIngredientForCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIngredientForCustomer.Size = new System.Drawing.Size(233, 75);
            this.txtIngredientForCustomer.TabIndex = 6;
            this.txtIngredientForCustomer.TextChanged += new System.EventHandler(this.txtIngredientForCustomer_TextChanged);
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
            // InformationIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtIngredientForCustomer);
            this.Controls.Add(this.txtIngridentOfficer);
            this.Controls.Add(this.lblIngredientForCustomer);
            this.Controls.Add(this.lblIngredientForOfficer);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cmbIngredient);
            this.Controls.Add(this.lblIngredientInfo);
            this.Menu = this.mnu;
            this.Name = "InformationIngredient";
            this.Text = "InformationIngredient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIngredientInfo;
        private System.Windows.Forms.ComboBox cmbIngredient;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblIngredientForOfficer;
        private System.Windows.Forms.Label lblIngredientForCustomer;
        private System.Windows.Forms.TextBox txtIngridentOfficer;
        private System.Windows.Forms.TextBox txtIngredientForCustomer;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}