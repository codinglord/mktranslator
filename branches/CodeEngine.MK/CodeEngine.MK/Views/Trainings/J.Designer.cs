namespace CodeEngine.MK.Views.Trainings
{
    partial class J
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
            this.lblHead = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnSayingWord = new System.Windows.Forms.Button();
            this.btnDescribing = new System.Windows.Forms.Button();
            this.btnLaw = new System.Windows.Forms.Button();
            this.btnPopular = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(3, 10);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 20);
            this.lblHead.Text = "lblHead";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(31, 33);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(187, 20);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "btnTime";
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(31, 59);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(187, 20);
            this.btnPlace.TabIndex = 2;
            this.btnPlace.Text = "btnPlace";
            // 
            // btnSayingWord
            // 
            this.btnSayingWord.Location = new System.Drawing.Point(31, 85);
            this.btnSayingWord.Name = "btnSayingWord";
            this.btnSayingWord.Size = new System.Drawing.Size(187, 20);
            this.btnSayingWord.TabIndex = 3;
            this.btnSayingWord.Text = "btnSayingWord";
            // 
            // btnDescribing
            // 
            this.btnDescribing.Location = new System.Drawing.Point(31, 111);
            this.btnDescribing.Name = "btnDescribing";
            this.btnDescribing.Size = new System.Drawing.Size(187, 20);
            this.btnDescribing.TabIndex = 4;
            this.btnDescribing.Text = "btnDescribing";
            // 
            // btnLaw
            // 
            this.btnLaw.Location = new System.Drawing.Point(31, 137);
            this.btnLaw.Name = "btnLaw";
            this.btnLaw.Size = new System.Drawing.Size(187, 20);
            this.btnLaw.TabIndex = 5;
            this.btnLaw.Text = "btnLaw";
            // 
            // btnPopular
            // 
            this.btnPopular.Location = new System.Drawing.Point(31, 163);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Size = new System.Drawing.Size(187, 20);
            this.btnPopular.TabIndex = 6;
            this.btnPopular.Text = "btnPopular";
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
            // J
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnPopular);
            this.Controls.Add(this.btnLaw);
            this.Controls.Add(this.btnDescribing);
            this.Controls.Add(this.btnSayingWord);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "J";
            this.Text = "J";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnSayingWord;
        private System.Windows.Forms.Button btnDescribing;
        private System.Windows.Forms.Button btnLaw;
        private System.Windows.Forms.Button btnPopular;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}