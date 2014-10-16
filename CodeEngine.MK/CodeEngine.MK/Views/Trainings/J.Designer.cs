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
            this.btnJ1 = new System.Windows.Forms.Button();
            this.btnJ2 = new System.Windows.Forms.Button();
            this.btnJ3 = new System.Windows.Forms.Button();
            this.btnJ4 = new System.Windows.Forms.Button();
            this.btnJ5 = new System.Windows.Forms.Button();
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
            // btnJ1
            // 
            this.btnJ1.Location = new System.Drawing.Point(31, 33);
            this.btnJ1.Name = "btnJ1";
            this.btnJ1.Size = new System.Drawing.Size(187, 20);
            this.btnJ1.TabIndex = 1;
            this.btnJ1.Text = "btnJ1";
            this.btnJ1.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnJ2
            // 
            this.btnJ2.Location = new System.Drawing.Point(31, 59);
            this.btnJ2.Name = "btnJ2";
            this.btnJ2.Size = new System.Drawing.Size(187, 20);
            this.btnJ2.TabIndex = 2;
            this.btnJ2.Text = "btnJ2";
            this.btnJ2.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnJ3
            // 
            this.btnJ3.Location = new System.Drawing.Point(31, 85);
            this.btnJ3.Name = "btnJ3";
            this.btnJ3.Size = new System.Drawing.Size(187, 20);
            this.btnJ3.TabIndex = 3;
            this.btnJ3.Text = "btnJ3";
            this.btnJ3.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnJ4
            // 
            this.btnJ4.Location = new System.Drawing.Point(31, 111);
            this.btnJ4.Name = "btnJ4";
            this.btnJ4.Size = new System.Drawing.Size(187, 20);
            this.btnJ4.TabIndex = 4;
            this.btnJ4.Text = "btnJ4";
            this.btnJ4.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnJ5
            // 
            this.btnJ5.Location = new System.Drawing.Point(31, 137);
            this.btnJ5.Name = "btnJ5";
            this.btnJ5.Size = new System.Drawing.Size(187, 20);
            this.btnJ5.TabIndex = 5;
            this.btnJ5.Text = "btnJ5";
            this.btnJ5.Click += new System.EventHandler(this.OnNavigate);
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
            this.Controls.Add(this.btnJ5);
            this.Controls.Add(this.btnJ4);
            this.Controls.Add(this.btnJ3);
            this.Controls.Add(this.btnJ2);
            this.Controls.Add(this.btnJ1);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "J";
            this.Text = "J";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnJ1;
        private System.Windows.Forms.Button btnJ2;
        private System.Windows.Forms.Button btnJ3;
        private System.Windows.Forms.Button btnJ4;
        private System.Windows.Forms.Button btnJ5;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}