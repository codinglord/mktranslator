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
            this.btnAccident = new System.Windows.Forms.Button();
            this.btnSuggestionStore = new System.Windows.Forms.Button();
            this.btnAboutService = new System.Windows.Forms.Button();
            this.btnSuggestedPrice = new System.Windows.Forms.Button();
            this.btnAboutProduct = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // btnAccident
            // 
            this.btnAccident.Location = new System.Drawing.Point(31, 137);
            this.btnAccident.Name = "btnAccident";
            this.btnAccident.Size = new System.Drawing.Size(187, 20);
            this.btnAccident.TabIndex = 12;
            this.btnAccident.Text = "btnAccident";
            // 
            // btnSuggestionStore
            // 
            this.btnSuggestionStore.Location = new System.Drawing.Point(31, 111);
            this.btnSuggestionStore.Name = "btnSuggestionStore";
            this.btnSuggestionStore.Size = new System.Drawing.Size(187, 20);
            this.btnSuggestionStore.TabIndex = 11;
            this.btnSuggestionStore.Text = "btnSuggestionStore";
            // 
            // btnAboutService
            // 
            this.btnAboutService.Location = new System.Drawing.Point(31, 85);
            this.btnAboutService.Name = "btnAboutService";
            this.btnAboutService.Size = new System.Drawing.Size(187, 20);
            this.btnAboutService.TabIndex = 10;
            this.btnAboutService.Text = "btnAboutService";
            // 
            // btnSuggestedPrice
            // 
            this.btnSuggestedPrice.Location = new System.Drawing.Point(31, 59);
            this.btnSuggestedPrice.Name = "btnSuggestedPrice";
            this.btnSuggestedPrice.Size = new System.Drawing.Size(187, 20);
            this.btnSuggestedPrice.TabIndex = 9;
            this.btnSuggestedPrice.Text = "btnSuggestedPrice";
            // 
            // btnAboutProduct
            // 
            this.btnAboutProduct.Location = new System.Drawing.Point(31, 33);
            this.btnAboutProduct.Name = "btnAboutProduct";
            this.btnAboutProduct.Size = new System.Drawing.Size(187, 20);
            this.btnAboutProduct.TabIndex = 8;
            this.btnAboutProduct.Text = "btnAboutProduct";
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
            this.Controls.Add(this.btnAccident);
            this.Controls.Add(this.btnSuggestionStore);
            this.Controls.Add(this.btnAboutService);
            this.Controls.Add(this.btnSuggestedPrice);
            this.Controls.Add(this.btnAboutProduct);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mnu;
            this.Name = "D";
            this.Text = "D";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccident;
        private System.Windows.Forms.Button btnSuggestionStore;
        private System.Windows.Forms.Button btnAboutService;
        private System.Windows.Forms.Button btnSuggestedPrice;
        private System.Windows.Forms.Button btnAboutProduct;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}