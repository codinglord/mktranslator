namespace CodeEngine.MK.Views.Conversations
{
    partial class G
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
            this.btnG3 = new System.Windows.Forms.Button();
            this.btnG2 = new System.Windows.Forms.Button();
            this.btnG1 = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // btnG3
            // 
            this.btnG3.Location = new System.Drawing.Point(31, 84);
            this.btnG3.Name = "btnG3";
            this.btnG3.Size = new System.Drawing.Size(187, 20);
            this.btnG3.TabIndex = 16;
            this.btnG3.Text = "btnG3";
            // 
            // btnG2
            // 
            this.btnG2.Location = new System.Drawing.Point(31, 58);
            this.btnG2.Name = "btnG2";
            this.btnG2.Size = new System.Drawing.Size(187, 20);
            this.btnG2.TabIndex = 15;
            this.btnG2.Text = "btnG2";
            // 
            // btnG1
            // 
            this.btnG1.Location = new System.Drawing.Point(31, 32);
            this.btnG1.Name = "btnG1";
            this.btnG1.Size = new System.Drawing.Size(187, 20);
            this.btnG1.TabIndex = 14;
            this.btnG1.Text = "btnG1";
            this.btnG1.Click += new System.EventHandler(this.OnNavigate);
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(3, 9);
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
            // G
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnG3);
            this.Controls.Add(this.btnG2);
            this.Controls.Add(this.btnG1);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "G";
            this.Text = "G";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnG3;
        private System.Windows.Forms.Button btnG2;
        private System.Windows.Forms.Button btnG1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}