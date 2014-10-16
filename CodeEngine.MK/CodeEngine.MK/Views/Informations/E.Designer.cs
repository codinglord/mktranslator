namespace CodeEngine.MK.Views.Informations
{
    partial class E
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblAskMemberForCustomer = new System.Windows.Forms.Label();
            this.lblAskMemberForOfficer = new System.Windows.Forms.Label();
            this.lblAskMemberSelect = new System.Windows.Forms.Label();
            this.cmbSelector = new System.Windows.Forms.ComboBox();
            this.lblAskMemberInfo = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(4, 192);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer.Size = new System.Drawing.Size(233, 75);
            this.txtAnswer.TabIndex = 19;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(4, 93);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuestion.Size = new System.Drawing.Size(233, 75);
            this.txtQuestion.TabIndex = 20;
            // 
            // lblAskMemberForCustomer
            // 
            this.lblAskMemberForCustomer.Location = new System.Drawing.Point(4, 172);
            this.lblAskMemberForCustomer.Name = "lblAskMemberForCustomer";
            this.lblAskMemberForCustomer.Size = new System.Drawing.Size(192, 20);
            this.lblAskMemberForCustomer.Text = "lblAskMemberForCustomer";
            // 
            // lblAskMemberForOfficer
            // 
            this.lblAskMemberForOfficer.Location = new System.Drawing.Point(4, 70);
            this.lblAskMemberForOfficer.Name = "lblAskMemberForOfficer";
            this.lblAskMemberForOfficer.Size = new System.Drawing.Size(135, 20);
            this.lblAskMemberForOfficer.Text = "lblAskMemberForOfficer";
            // 
            // lblAskMemberSelect
            // 
            this.lblAskMemberSelect.Location = new System.Drawing.Point(4, 22);
            this.lblAskMemberSelect.Name = "lblAskMemberSelect";
            this.lblAskMemberSelect.Size = new System.Drawing.Size(100, 20);
            this.lblAskMemberSelect.Text = "lblAskMemberSelect";
            // 
            // cmbSelector
            // 
            this.cmbSelector.Location = new System.Drawing.Point(4, 45);
            this.cmbSelector.Name = "cmbSelector";
            this.cmbSelector.Size = new System.Drawing.Size(233, 22);
            this.cmbSelector.TabIndex = 18;
            this.cmbSelector.SelectedIndexChanged += new System.EventHandler(this.cmbSelector_SelectedIndexChanged);
            // 
            // lblAskMemberInfo
            // 
            this.lblAskMemberInfo.Location = new System.Drawing.Point(3, 2);
            this.lblAskMemberInfo.Name = "lblAskMemberInfo";
            this.lblAskMemberInfo.Size = new System.Drawing.Size(100, 20);
            this.lblAskMemberInfo.Text = "lblAskMemberInfo";
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
            // InformationAskMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblAskMemberForCustomer);
            this.Controls.Add(this.lblAskMemberForOfficer);
            this.Controls.Add(this.lblAskMemberSelect);
            this.Controls.Add(this.cmbSelector);
            this.Controls.Add(this.lblAskMemberInfo);
            this.Menu = this.mnu;
            this.Name = "InformationAskMember";
            this.Text = "InformationAskMember";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAskMemberForCustomer;
        private System.Windows.Forms.Label lblAskMemberForOfficer;
        private System.Windows.Forms.Label lblAskMemberSelect;
        private System.Windows.Forms.ComboBox cmbSelector;
        private System.Windows.Forms.Label lblAskMemberInfo;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}