namespace CodeEngine.MK.Views.Conversations
{
    partial class I
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
            this.btnI3 = new System.Windows.Forms.Button();
            this.btnI2 = new System.Windows.Forms.Button();
            this.btnI1 = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnI4 = new System.Windows.Forms.Button();
            this.btnI5 = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // btnI3
            // 
            this.btnI3.Location = new System.Drawing.Point(31, 84);
            this.btnI3.Name = "btnI3";
            this.btnI3.Size = new System.Drawing.Size(187, 20);
            this.btnI3.TabIndex = 20;
            this.btnI3.Text = "btnI3";
            this.btnI3.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnI2
            // 
            this.btnI2.Location = new System.Drawing.Point(31, 58);
            this.btnI2.Name = "btnI2";
            this.btnI2.Size = new System.Drawing.Size(187, 20);
            this.btnI2.TabIndex = 19;
            this.btnI2.Text = "btnI2";
            this.btnI2.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnI1
            // 
            this.btnI1.Location = new System.Drawing.Point(31, 32);
            this.btnI1.Name = "btnI1";
            this.btnI1.Size = new System.Drawing.Size(187, 20);
            this.btnI1.TabIndex = 18;
            this.btnI1.Text = "btnI1";
            this.btnI1.Click += new System.EventHandler(this.OnNavigate);
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(3, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 20);
            this.lblHead.Text = "lblHead";
            // 
            // btnI4
            // 
            this.btnI4.Location = new System.Drawing.Point(31, 110);
            this.btnI4.Name = "btnI4";
            this.btnI4.Size = new System.Drawing.Size(187, 20);
            this.btnI4.TabIndex = 22;
            this.btnI4.Text = "btnI4";
            this.btnI4.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnI5
            // 
            this.btnI5.Location = new System.Drawing.Point(31, 137);
            this.btnI5.Name = "btnI5";
            this.btnI5.Size = new System.Drawing.Size(187, 20);
            this.btnI5.TabIndex = 23;
            this.btnI5.Text = "btnI5";
            this.btnI5.Click += new System.EventHandler(this.OnNavigate);
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
            // I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnI5);
            this.Controls.Add(this.btnI4);
            this.Controls.Add(this.btnI3);
            this.Controls.Add(this.btnI2);
            this.Controls.Add(this.btnI1);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "I";
            this.Text = "I";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnI3;
        private System.Windows.Forms.Button btnI2;
        private System.Windows.Forms.Button btnI1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnI4;
        private System.Windows.Forms.Button btnI5;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}