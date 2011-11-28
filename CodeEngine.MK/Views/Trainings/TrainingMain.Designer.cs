namespace CodeEngine.MK.Views.Trainings
{
    partial class TrainingMain
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
            this.btnMain = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.langBoard = new CodeEngine.MK.Views.LanguageBoard();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(3, 115);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(100, 20);
            this.lblInformation.Text = "lblInformation";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(165, 245);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(72, 20);
            this.btnMain.TabIndex = 12;
            this.btnMain.Text = "btnMain";
            this.btnMain.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(3, 189);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(116, 45);
            this.btnK.TabIndex = 9;
            this.btnK.Text = "btnK";
            this.btnK.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(3, 138);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(116, 45);
            this.btnJ.TabIndex = 10;
            this.btnJ.Text = "btnJ";
            this.btnJ.Click += new System.EventHandler(this.OnNavigate);
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
            this.langBoard.Size = new System.Drawing.Size(234, 109);
            this.langBoard.TabIndex = 0;
            // 
            // TrainingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.langBoard);
            this.Menu = this.mnu;
            this.Name = "TrainingMain";
            this.Text = "TrainingMain";
            this.ResumeLayout(false);

        }

        #endregion

        private LanguageBoard langBoard;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}