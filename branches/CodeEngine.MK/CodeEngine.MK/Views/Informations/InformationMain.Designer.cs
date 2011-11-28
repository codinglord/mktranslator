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
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.langBoard = new CodeEngine.MK.Views.LanguageBoard();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(3, 112);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(100, 20);
            this.lblInformation.Text = "lblInformation";
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(25, 135);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(116, 45);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "btnB";
            this.btnB.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(25, 186);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(116, 45);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "btnC";
            this.btnC.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(25, 237);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(116, 45);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "btnE";
            this.btnE.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(165, 262);
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
            // langBoard
            // 
            this.langBoard.Location = new System.Drawing.Point(3, 3);
            this.langBoard.Name = "langBoard";
            this.langBoard.Size = new System.Drawing.Size(234, 104);
            this.langBoard.TabIndex = 0;
            // 
            // InformationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
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
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}