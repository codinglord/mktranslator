namespace CodeEngine.MK.Views.Conversations
{
    partial class I1
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
            this.lblSelector = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.cmbSelector2 = new System.Windows.Forms.ComboBox();
            this.lblSelector2 = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // cmbSelector
            // 
            this.cmbSelector.Location = new System.Drawing.Point(4, 52);
            this.cmbSelector.Name = "cmbSelector";
            this.cmbSelector.Size = new System.Drawing.Size(233, 22);
            this.cmbSelector.TabIndex = 35;
            this.cmbSelector.SelectedIndexChanged += new System.EventHandler(this.cmbSelector_SelectedIndexChanged);
            // 
            // lblSelector
            // 
            this.lblSelector.Location = new System.Drawing.Point(4, 29);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(100, 20);
            this.lblSelector.Text = "lblSelector";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(4, 100);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuestion.Size = new System.Drawing.Size(233, 75);
            this.txtQuestion.TabIndex = 37;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(4, 77);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(135, 20);
            this.lblQuestion.Text = "lblQuestion";
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(3, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 20);
            this.lblHead.Text = "lblHead";
            // 
            // cmbSelector2
            // 
            this.cmbSelector2.Location = new System.Drawing.Point(4, 201);
            this.cmbSelector2.Name = "cmbSelector2";
            this.cmbSelector2.Size = new System.Drawing.Size(233, 22);
            this.cmbSelector2.TabIndex = 42;
            this.cmbSelector2.SelectedIndexChanged += new System.EventHandler(this.cmbSelector2_SelectedIndexChanged);
            // 
            // lblSelector2
            // 
            this.lblSelector2.Location = new System.Drawing.Point(4, 178);
            this.lblSelector2.Name = "lblSelector2";
            this.lblSelector2.Size = new System.Drawing.Size(100, 20);
            this.lblSelector2.Text = "lblAnswer";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(4, 249);
            this.txtAnswer2.Multiline = true;
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer2.Size = new System.Drawing.Size(233, 75);
            this.txtAnswer2.TabIndex = 43;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.Location = new System.Drawing.Point(4, 226);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(135, 20);
            this.lblAnswer2.Text = "lblAnswer2";
            // 
            // mnu
            // 
            this.mnu.MenuItems.Add(this.mnuChangeLanguage);
            this.mnu.MenuItems.Add(this.mnuCurrentLanguage);
            // 
            // mnuChangeLanguage
            // 
            this.mnuChangeLanguage.Text = "เปลี่ยนภาษา";
            // 
            // mnuCurrentLanguage
            // 
            this.mnuCurrentLanguage.Enabled = false;
            this.mnuCurrentLanguage.Text = " ";
            // 
            // I1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmbSelector2);
            this.Controls.Add(this.lblSelector2);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.cmbSelector);
            this.Controls.Add(this.lblSelector);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "I1";
            this.Text = "I1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelector;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.ComboBox cmbSelector2;
        private System.Windows.Forms.Label lblSelector2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}