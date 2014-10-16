namespace CodeEngine.MK.Views.Trainings
{
    partial class J3
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
            this.cmbSelector = new System.Windows.Forms.ComboBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblSelector = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // cmbSelector
            // 
            this.cmbSelector.Location = new System.Drawing.Point(4, 54);
            this.cmbSelector.Name = "cmbSelector";
            this.cmbSelector.Size = new System.Drawing.Size(233, 22);
            this.cmbSelector.TabIndex = 41;
            this.cmbSelector.SelectedIndexChanged += new System.EventHandler(this.cmbSelector_SelectedIndexChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(4, 102);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuestion.Size = new System.Drawing.Size(233, 75);
            this.txtQuestion.TabIndex = 42;
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(3, 11);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 20);
            this.lblHead.Text = "lblHead";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(4, 79);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(135, 20);
            this.lblQuestion.Text = "lblQuestion";
            // 
            // lblSelector
            // 
            this.lblSelector.Location = new System.Drawing.Point(4, 31);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(100, 20);
            this.lblSelector.Text = "lblSelector";
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
            // J3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmbSelector);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblSelector);
            this.Menu = this.mnu;
            this.Name = "J3";
            this.Text = "J3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelector;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}