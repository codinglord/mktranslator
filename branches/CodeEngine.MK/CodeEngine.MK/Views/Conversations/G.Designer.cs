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
            this.btnAccommodation = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.btnForOtherPlaces = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // btnAccommodation
            // 
            this.btnAccommodation.Location = new System.Drawing.Point(31, 84);
            this.btnAccommodation.Name = "btnAccommodation";
            this.btnAccommodation.Size = new System.Drawing.Size(187, 20);
            this.btnAccommodation.TabIndex = 16;
            this.btnAccommodation.Text = "btnAccommodation";
            // 
            // btnShopping
            // 
            this.btnShopping.Location = new System.Drawing.Point(31, 58);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(187, 20);
            this.btnShopping.TabIndex = 15;
            this.btnShopping.Text = "btnShopping";
            // 
            // btnForOtherPlaces
            // 
            this.btnForOtherPlaces.Location = new System.Drawing.Point(31, 32);
            this.btnForOtherPlaces.Name = "btnForOtherPlaces";
            this.btnForOtherPlaces.Size = new System.Drawing.Size(187, 20);
            this.btnForOtherPlaces.TabIndex = 14;
            this.btnForOtherPlaces.Text = "btnForOtherPlaces";
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
            this.Controls.Add(this.btnAccommodation);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnForOtherPlaces);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "G";
            this.Text = "G";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccommodation;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button btnForOtherPlaces;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}