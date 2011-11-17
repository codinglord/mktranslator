namespace CodeEngine.MK.Views.Trainings
{
    partial class TrainingMain
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnConversation = new System.Windows.Forms.Button();
            this.btnVocaburary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // langBoard
            // 
            this.langBoard.Location = new System.Drawing.Point(3, 3);
            this.langBoard.Name = "langBoard";
            this.langBoard.Size = new System.Drawing.Size(234, 109);
            this.langBoard.TabIndex = 0;
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
            // btnConversation
            // 
            this.btnConversation.Location = new System.Drawing.Point(3, 189);
            this.btnConversation.Name = "btnConversation";
            this.btnConversation.Size = new System.Drawing.Size(116, 45);
            this.btnConversation.TabIndex = 9;
            this.btnConversation.Text = "btnConversation";
            this.btnConversation.Click += new System.EventHandler(this.OnNavigate);
            // 
            // btnVocaburary
            // 
            this.btnVocaburary.Location = new System.Drawing.Point(3, 138);
            this.btnVocaburary.Name = "btnVocaburary";
            this.btnVocaburary.Size = new System.Drawing.Size(116, 45);
            this.btnVocaburary.TabIndex = 10;
            this.btnVocaburary.Text = "btnVocaburary";
            this.btnVocaburary.Click += new System.EventHandler(this.OnNavigate);
            // 
            // TrainingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnConversation);
            this.Controls.Add(this.btnVocaburary);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.langBoard);
            this.Menu = this.mainMenu1;
            this.Name = "TrainingMain";
            this.Text = "TrainingMain";
            this.ResumeLayout(false);

        }

        #endregion

        private LanguageBoard langBoard;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnConversation;
        private System.Windows.Forms.Button btnVocaburary;
    }
}