namespace CodeEngine.MK.Views.Informations
{
    partial class InformationMain
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
            this.langBoard = new CodeEngine.MK.Views.LanguageBoard();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnIngredient = new System.Windows.Forms.Button();
            this.btnAboutMK = new System.Windows.Forms.Button();
            this.btnAskMember = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // langBoard
            // 
            this.langBoard.Location = new System.Drawing.Point(3, 3);
            this.langBoard.Name = "langBoard";
            this.langBoard.Size = new System.Drawing.Size(234, 84);
            this.langBoard.TabIndex = 0;
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(3, 90);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(100, 20);
            this.lblInformation.Text = "lblInformation";
            // 
            // btnIngredient
            // 
            this.btnIngredient.Location = new System.Drawing.Point(25, 113);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(116, 45);
            this.btnIngredient.TabIndex = 4;
            this.btnIngredient.Text = "btnIngredient";
            this.btnIngredient.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnAboutMK
            // 
            this.btnAboutMK.Location = new System.Drawing.Point(25, 164);
            this.btnAboutMK.Name = "btnAboutMK";
            this.btnAboutMK.Size = new System.Drawing.Size(116, 45);
            this.btnAboutMK.TabIndex = 4;
            this.btnAboutMK.Text = "btnAboutMK";
            this.btnAboutMK.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnAskMember
            // 
            this.btnAskMember.Location = new System.Drawing.Point(25, 215);
            this.btnAskMember.Name = "btnAskMember";
            this.btnAskMember.Size = new System.Drawing.Size(116, 45);
            this.btnAskMember.TabIndex = 4;
            this.btnAskMember.Text = "btnAskMember";
            this.btnAskMember.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(165, 240);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(72, 20);
            this.btnMain.TabIndex = 8;
            this.btnMain.Text = "btnMain";
            this.btnMain.Click += new System.EventHandler(this.OnNavigate);
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
            // InformationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAskMember);
            this.Controls.Add(this.btnAboutMK);
            this.Controls.Add(this.btnIngredient);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.langBoard);
            this.Menu = this.mnu;
            this.Name = "InformationMain";
            this.Text = "InformationMain";
            this.ResumeLayout(false);

        }

        #endregion

        private LanguageBoard langBoard;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnIngredient;
        private System.Windows.Forms.Button btnAboutMK;
        private System.Windows.Forms.Button btnAskMember;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}