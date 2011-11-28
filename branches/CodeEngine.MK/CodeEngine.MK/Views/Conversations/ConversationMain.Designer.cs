namespace CodeEngine.MK.Views.Conversations
{
    partial class ConversationMain
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
            this.lblConversation = new System.Windows.Forms.Label();
            this.btnI = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.mnu = new System.Windows.Forms.MainMenu();
            this.mnuChangeLanguage = new System.Windows.Forms.MenuItem();
            this.mnuCurrentLanguage = new System.Windows.Forms.MenuItem();
            this.langBoard = new CodeEngine.MK.Views.LanguageBoard();
            this.SuspendLayout();
            // 
            // lblConversation
            // 
            this.lblConversation.Location = new System.Drawing.Point(3, 110);
            this.lblConversation.Name = "lblConversation";
            this.lblConversation.Size = new System.Drawing.Size(100, 20);
            this.lblConversation.Text = "lblConversation";
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(3, 133);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(116, 37);
            this.btnI.TabIndex = 2;
            this.btnI.Text = "btnI";
            this.btnI.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(3, 176);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(116, 36);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "btnD";
            this.btnD.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(125, 176);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(112, 36);
            this.btnH.TabIndex = 4;
            this.btnH.Text = "btnH";
            this.btnH.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(125, 133);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(112, 37);
            this.btnF.TabIndex = 5;
            this.btnF.Text = "btnF";
            this.btnF.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(3, 218);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(116, 36);
            this.btnG.TabIndex = 6;
            this.btnG.Text = "btnG";
            this.btnG.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(165, 245);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(72, 20);
            this.btnMain.TabIndex = 7;
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
            // ConversationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.lblConversation);
            this.Controls.Add(this.langBoard);
            this.Menu = this.mnu;
            this.Name = "ConversationMain";
            this.Text = "ConversationMain";
            this.ResumeLayout(false);

        }

        #endregion

        private LanguageBoard langBoard;
        private System.Windows.Forms.Label lblConversation;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.MainMenu mnu;
        private System.Windows.Forms.MenuItem mnuChangeLanguage;
        private System.Windows.Forms.MenuItem mnuCurrentLanguage;
    }
}