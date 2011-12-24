namespace CodeEngine.MK.Views
{
    partial class Portal
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
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnConversation = new System.Windows.Forms.Button();
            this.btnTraning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // langBoard
            // 
            this.langBoard.Location = new System.Drawing.Point(3, 9);
            this.langBoard.Name = "langBoard";
            this.langBoard.Size = new System.Drawing.Size(234, 84);
            this.langBoard.TabIndex = 9;
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(68, 115);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(96, 40);
            this.btnInformation.TabIndex = 10;
            this.btnInformation.Text = "Information";
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnConversation
            // 
            this.btnConversation.Location = new System.Drawing.Point(68, 161);
            this.btnConversation.Name = "btnConversation";
            this.btnConversation.Size = new System.Drawing.Size(96, 40);
            this.btnConversation.TabIndex = 11;
            this.btnConversation.Text = "Conversation";
            this.btnConversation.Click += new System.EventHandler(this.btnConversation_Click);
            // 
            // btnTraning
            // 
            this.btnTraning.Location = new System.Drawing.Point(68, 207);
            this.btnTraning.Name = "btnTraning";
            this.btnTraning.Size = new System.Drawing.Size(96, 40);
            this.btnTraning.TabIndex = 12;
            this.btnTraning.Text = "Traning";
            this.btnTraning.Click += new System.EventHandler(this.btnTraning_Click);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnTraning);
            this.Controls.Add(this.btnConversation);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.langBoard);
            this.Menu = this.mainMenu1;
            this.Name = "Portal";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.MainInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LanguageBoard langBoard;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnConversation;
        private System.Windows.Forms.Button btnTraning;
    }
}