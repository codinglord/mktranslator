namespace CodeEngine.MK.Views.Conversations
{
    partial class D
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
            this.btnD5 = new System.Windows.Forms.Button();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD3 = new System.Windows.Forms.Button();
            this.btnD2 = new System.Windows.Forms.Button();
            this.btnD1 = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // btnD5
            // 
            this.btnD5.Location = new System.Drawing.Point(31, 137);
            this.btnD5.Name = "btnD5";
            this.btnD5.Size = new System.Drawing.Size(187, 20);
            this.btnD5.TabIndex = 12;
            this.btnD5.Text = "btnD5";
            this.btnD5.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(31, 111);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(187, 20);
            this.btnD4.TabIndex = 11;
            this.btnD4.Text = "btnD4";
            this.btnD4.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnD3
            // 
            this.btnD3.Location = new System.Drawing.Point(31, 85);
            this.btnD3.Name = "btnD3";
            this.btnD3.Size = new System.Drawing.Size(187, 20);
            this.btnD3.TabIndex = 10;
            this.btnD3.Text = "btnD3";
            this.btnD3.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnD2
            // 
            this.btnD2.Location = new System.Drawing.Point(31, 59);
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(187, 20);
            this.btnD2.TabIndex = 9;
            this.btnD2.Text = "btnD2";
            this.btnD2.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnD1
            // 
            this.btnD1.Location = new System.Drawing.Point(31, 33);
            this.btnD1.Name = "btnD1";
            this.btnD1.Size = new System.Drawing.Size(187, 20);
            this.btnD1.TabIndex = 8;
            this.btnD1.Text = "btnD1";
            this.btnD1.Click += new System.EventHandler(this.OnNavigate);
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(3, 10);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 20);
            this.lblHead.Text = "lblHead";
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
            // D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnD5);
            this.Controls.Add(this.btnD4);
            this.Controls.Add(this.btnD3);
            this.Controls.Add(this.btnD2);
            this.Controls.Add(this.btnD1);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "D";
            this.Text = "D";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnD5;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD3;
        private System.Windows.Forms.Button btnD2;
        private System.Windows.Forms.Button btnD1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}