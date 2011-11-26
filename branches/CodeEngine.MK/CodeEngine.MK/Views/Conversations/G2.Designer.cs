namespace CodeEngine.MK.Views.Conversations
{
    partial class G2
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.mainMenu4 = new System.Windows.Forms.MainMenu();
            this.mainMenu3 = new System.Windows.Forms.MainMenu();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblSelector = new System.Windows.Forms.Label();
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.cmbSelector = new System.Windows.Forms.ComboBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.mainMenu5 = new System.Windows.Forms.MainMenu();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(4, 91);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuestion.Size = new System.Drawing.Size(233, 75);
            this.txtQuestion.TabIndex = 32;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(4, 68);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(135, 20);
            this.lblQuestion.Text = "lblQuestion";
            // 
            // lblSelector
            // 
            this.lblSelector.Location = new System.Drawing.Point(4, 20);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(100, 20);
            this.lblSelector.Text = "lblSelector";
            // 
            // cmbSelector
            // 
            this.cmbSelector.Location = new System.Drawing.Point(4, 43);
            this.cmbSelector.Name = "cmbSelector";
            this.cmbSelector.Size = new System.Drawing.Size(233, 22);
            this.cmbSelector.TabIndex = 31;
            this.cmbSelector.SelectedIndexChanged += new System.EventHandler(this.cmbSelector_SelectedIndexChanged);
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(3, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 20);
            this.lblHead.Text = "lblHead";
            // 
            // G2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblSelector);
            this.Controls.Add(this.cmbSelector);
            this.Controls.Add(this.lblHead);
            this.Menu = this.mainMenu1;
            this.Name = "G2";
            this.Text = "G2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.MainMenu mainMenu4;
        private System.Windows.Forms.MainMenu mainMenu3;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.ComboBox cmbSelector;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.MainMenu mainMenu5;

    }
}