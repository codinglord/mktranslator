namespace CodeEngine.MK.Views
{
    partial class MainInformation
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnIngredient = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.langBoard = new CodeEngine.MK.Views.LanguageBoard();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(3, 99);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(100, 20);
            this.lblInformation.Tag = "";
            this.lblInformation.Text = "lblInformation";
            // 
            // btnIngredient
            // 
            this.btnIngredient.Location = new System.Drawing.Point(69, 123);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(96, 33);
            this.btnIngredient.TabIndex = 7;
            this.btnIngredient.Tag = "";
            this.btnIngredient.Text = "btnIngredient";
            this.btnIngredient.Click += new System.EventHandler(this.btnIngredient_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(69, 164);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(96, 33);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Tag = "";
            this.btnAbout.Text = "btnAbout";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(69, 205);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(96, 33);
            this.btnAsk.TabIndex = 7;
            this.btnAsk.Tag = "";
            this.btnAsk.Text = "btnAsk";
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(145, 243);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(89, 19);
            this.btnMain.TabIndex = 8;
            this.btnMain.Tag = "";
            this.btnMain.Text = "btnMain";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // langBoard
            // 
            this.langBoard.Location = new System.Drawing.Point(3, 9);
            this.langBoard.Name = "langBoard";
            this.langBoard.Size = new System.Drawing.Size(234, 84);
            this.langBoard.TabIndex = 9;
            // 
            // MainInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.langBoard);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnIngredient);
            this.Controls.Add(this.lblInformation);
            this.Menu = this.mainMenu1;
            this.Name = "MainInformation";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.MainInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnIngredient;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Button btnMain;
        private LanguageBoard langBoard;
    }
}