namespace CodeEngine.MK.Views.Conversations
{
    partial class ConversationMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.langBoard = new CodeEngine.MK.Views.LanguageBoard();
            this.lblConversation = new System.Windows.Forms.Label();
            this.btnConversationEtc = new System.Windows.Forms.Button();
            this.btnAccquire = new System.Windows.Forms.Button();
            this.btnAskMap = new System.Windows.Forms.Button();
            this.btnRecommendMenu = new System.Windows.Forms.Button();
            this.btnAskPrice = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // langBoard
            // 
            this.langBoard.Location = new System.Drawing.Point(3, 3);
            this.langBoard.Name = "langBoard";
            this.langBoard.Size = new System.Drawing.Size(234, 104);
            this.langBoard.TabIndex = 0;
            // 
            // lblConversation
            // 
            this.lblConversation.Location = new System.Drawing.Point(3, 110);
            this.lblConversation.Name = "lblConversation";
            this.lblConversation.Size = new System.Drawing.Size(100, 20);
            this.lblConversation.Text = "lblConversation";
            // 
            // btnConversationEtc
            // 
            this.btnConversationEtc.Location = new System.Drawing.Point(3, 133);
            this.btnConversationEtc.Name = "btnConversationEtc";
            this.btnConversationEtc.Size = new System.Drawing.Size(116, 37);
            this.btnConversationEtc.TabIndex = 2;
            this.btnConversationEtc.Text = "btnConversationEtc";
            this.btnConversationEtc.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnAccquire
            // 
            this.btnAccquire.Location = new System.Drawing.Point(3, 176);
            this.btnAccquire.Name = "btnAccquire";
            this.btnAccquire.Size = new System.Drawing.Size(116, 36);
            this.btnAccquire.TabIndex = 3;
            this.btnAccquire.Text = "btnAccquire";
            this.btnAccquire.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnAskMap
            // 
            this.btnAskMap.Location = new System.Drawing.Point(125, 176);
            this.btnAskMap.Name = "btnAskMap";
            this.btnAskMap.Size = new System.Drawing.Size(112, 36);
            this.btnAskMap.TabIndex = 4;
            this.btnAskMap.Text = "btnAskMap";
            this.btnAskMap.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnRecommendMenu
            // 
            this.btnRecommendMenu.Location = new System.Drawing.Point(125, 133);
            this.btnRecommendMenu.Name = "btnRecommendMenu";
            this.btnRecommendMenu.Size = new System.Drawing.Size(112, 37);
            this.btnRecommendMenu.TabIndex = 5;
            this.btnRecommendMenu.Text = "btnRecommendMenu";
            this.btnRecommendMenu.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnAskPrice
            // 
            this.btnAskPrice.Location = new System.Drawing.Point(3, 218);
            this.btnAskPrice.Name = "btnAskPrice";
            this.btnAskPrice.Size = new System.Drawing.Size(116, 36);
            this.btnAskPrice.TabIndex = 6;
            this.btnAskPrice.Text = "btnAskPrice";
            this.btnAskPrice.Click += new System.EventHandler(this.OnNavigate);
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
            // ConversationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAskPrice);
            this.Controls.Add(this.btnRecommendMenu);
            this.Controls.Add(this.btnAskMap);
            this.Controls.Add(this.btnAccquire);
            this.Controls.Add(this.btnConversationEtc);
            this.Controls.Add(this.lblConversation);
            this.Controls.Add(this.langBoard);
            this.Menu = this.mainMenu1;
            this.Name = "ConversationMain";
            this.Text = "ConversationMain";
            this.ResumeLayout(false);

        }

        #endregion

        private LanguageBoard langBoard;
        private System.Windows.Forms.Label lblConversation;
        private System.Windows.Forms.Button btnConversationEtc;
        private System.Windows.Forms.Button btnAccquire;
        private System.Windows.Forms.Button btnAskMap;
        private System.Windows.Forms.Button btnRecommendMenu;
        private System.Windows.Forms.Button btnAskPrice;
        private System.Windows.Forms.Button btnMain;
    }
}