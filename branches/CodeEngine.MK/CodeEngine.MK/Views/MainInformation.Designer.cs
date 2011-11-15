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
            this.rb_en = new System.Windows.Forms.RadioButton();
            this.rb_ru = new System.Windows.Forms.RadioButton();
            this.rb_vi = new System.Windows.Forms.RadioButton();
            this.rb_ko = new System.Windows.Forms.RadioButton();
            this.rb_ja = new System.Windows.Forms.RadioButton();
            this.rb_zh = new System.Windows.Forms.RadioButton();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnIngredient = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_en
            // 
            this.rb_en.Checked = true;
            this.rb_en.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_en.Location = new System.Drawing.Point(3, 23);
            this.rb_en.Name = "rb_en";
            this.rb_en.Size = new System.Drawing.Size(111, 20);
            this.rb_en.TabIndex = 0;
            this.rb_en.Tag = "LanguageOption";
            this.rb_en.Text = "English อังกฤษ";
            this.rb_en.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_ru
            // 
            this.rb_ru.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_ru.Location = new System.Drawing.Point(3, 49);
            this.rb_ru.Name = "rb_ru";
            this.rb_ru.Size = new System.Drawing.Size(111, 20);
            this.rb_ru.TabIndex = 1;
            this.rb_ru.TabStop = false;
            this.rb_ru.Tag = "LanguageOption";
            this.rb_ru.Text = "Русский (รัชเชีย)";
            this.rb_ru.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_vi
            // 
            this.rb_vi.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_vi.Location = new System.Drawing.Point(3, 75);
            this.rb_vi.Name = "rb_vi";
            this.rb_vi.Size = new System.Drawing.Size(111, 20);
            this.rb_vi.TabIndex = 2;
            this.rb_vi.TabStop = false;
            this.rb_vi.Tag = "LanguageOption";
            this.rb_vi.Text = "Tiếng Việt(เวียดนาม)";
            this.rb_vi.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_ko
            // 
            this.rb_ko.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_ko.Location = new System.Drawing.Point(120, 23);
            this.rb_ko.Name = "rb_ko";
            this.rb_ko.Size = new System.Drawing.Size(117, 20);
            this.rb_ko.TabIndex = 3;
            this.rb_ko.TabStop = false;
            this.rb_ko.Tag = "LanguageOption";
            this.rb_ko.Text = "한국어 เกาหลี";
            this.rb_ko.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_ja
            // 
            this.rb_ja.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_ja.Location = new System.Drawing.Point(120, 49);
            this.rb_ja.Name = "rb_ja";
            this.rb_ja.Size = new System.Drawing.Size(117, 20);
            this.rb_ja.TabIndex = 4;
            this.rb_ja.TabStop = false;
            this.rb_ja.Tag = "LanguageOption";
            this.rb_ja.Text = "日本語 (ญี่ปุ่น)";
            this.rb_ja.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_zh
            // 
            this.rb_zh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_zh.Location = new System.Drawing.Point(120, 75);
            this.rb_zh.Name = "rb_zh";
            this.rb_zh.Size = new System.Drawing.Size(117, 20);
            this.rb_zh.TabIndex = 5;
            this.rb_zh.TabStop = false;
            this.rb_zh.Tag = "LanguageOption";
            this.rb_zh.Text = "繁體中文 (台灣) จีน";
            this.rb_zh.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(3, 99);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(100, 20);
            this.lblInformation.Tag = "informationlabel";
            this.lblInformation.Text = "lblInformation";
            // 
            // btnIngredient
            // 
            this.btnIngredient.Location = new System.Drawing.Point(69, 123);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(96, 33);
            this.btnIngredient.TabIndex = 7;
            this.btnIngredient.Tag = "ingredientbutton";
            this.btnIngredient.Text = "btnIngredient";
            this.btnIngredient.Click += new System.EventHandler(this.btnIngredient_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(69, 164);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(96, 33);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Tag = "aboutbutton";
            this.btnAbout.Text = "btnAbout";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(69, 205);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(96, 33);
            this.btnAsk.TabIndex = 7;
            this.btnAsk.Tag = "askbutton";
            this.btnAsk.Text = "btnAsk";
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(145, 243);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(89, 19);
            this.btnMain.TabIndex = 8;
            this.btnMain.Tag = "mainbutton";
            this.btnMain.Text = "btnMain";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // MainInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnIngredient);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.rb_zh);
            this.Controls.Add(this.rb_ja);
            this.Controls.Add(this.rb_ko);
            this.Controls.Add(this.rb_vi);
            this.Controls.Add(this.rb_ru);
            this.Controls.Add(this.rb_en);
            this.Menu = this.mainMenu1;
            this.Name = "MainInformation";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.MainInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_en;
        private System.Windows.Forms.RadioButton rb_ru;
        private System.Windows.Forms.RadioButton rb_vi;
        private System.Windows.Forms.RadioButton rb_ko;
        private System.Windows.Forms.RadioButton rb_ja;
        private System.Windows.Forms.RadioButton rb_zh;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnIngredient;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Button btnMain;
    }
}