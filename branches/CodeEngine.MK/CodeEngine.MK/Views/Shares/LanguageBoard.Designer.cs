namespace CodeEngine.MK.Views
{
    partial class LanguageBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_zh = new System.Windows.Forms.RadioButton();
            this.rb_ja = new System.Windows.Forms.RadioButton();
            this.rb_ko = new System.Windows.Forms.RadioButton();
            this.rb_vi = new System.Windows.Forms.RadioButton();
            this.rb_ru = new System.Windows.Forms.RadioButton();
            this.rb_en = new System.Windows.Forms.RadioButton();
            this.rb_th = new System.Windows.Forms.RadioButton();
            this.lblChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_zh
            // 
            this.rb_zh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_zh.Location = new System.Drawing.Point(115, 79);
            this.rb_zh.Name = "rb_zh";
            this.rb_zh.Size = new System.Drawing.Size(117, 20);
            this.rb_zh.TabIndex = 11;
            this.rb_zh.TabStop = false;
            this.rb_zh.Tag = "LanguageOption";
            this.rb_zh.Text = "繁體中文 (台灣) จีน";
            this.rb_zh.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_ja
            // 
            this.rb_ja.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_ja.Location = new System.Drawing.Point(115, 55);
            this.rb_ja.Name = "rb_ja";
            this.rb_ja.Size = new System.Drawing.Size(117, 20);
            this.rb_ja.TabIndex = 10;
            this.rb_ja.TabStop = false;
            this.rb_ja.Tag = "LanguageOption";
            this.rb_ja.Text = "日本語 (ญี่ปุ่น)";
            this.rb_ja.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_ko
            // 
            this.rb_ko.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_ko.Location = new System.Drawing.Point(115, 29);
            this.rb_ko.Name = "rb_ko";
            this.rb_ko.Size = new System.Drawing.Size(117, 20);
            this.rb_ko.TabIndex = 9;
            this.rb_ko.TabStop = false;
            this.rb_ko.Tag = "LanguageOption";
            this.rb_ko.Text = "한국어 เกาหลี";
            this.rb_ko.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_vi
            // 
            this.rb_vi.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_vi.Location = new System.Drawing.Point(-2, 79);
            this.rb_vi.Name = "rb_vi";
            this.rb_vi.Size = new System.Drawing.Size(111, 20);
            this.rb_vi.TabIndex = 8;
            this.rb_vi.TabStop = false;
            this.rb_vi.Tag = "LanguageOption";
            this.rb_vi.Text = "Tiếng Việt(เวียดนาม)";
            this.rb_vi.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_ru
            // 
            this.rb_ru.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_ru.Location = new System.Drawing.Point(-2, 55);
            this.rb_ru.Name = "rb_ru";
            this.rb_ru.Size = new System.Drawing.Size(111, 20);
            this.rb_ru.TabIndex = 7;
            this.rb_ru.TabStop = false;
            this.rb_ru.Tag = "LanguageOption";
            this.rb_ru.Text = "Русский (รัชเชีย)";
            this.rb_ru.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_en
            // 
            this.rb_en.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_en.Location = new System.Drawing.Point(-2, 29);
            this.rb_en.Name = "rb_en";
            this.rb_en.Size = new System.Drawing.Size(111, 20);
            this.rb_en.TabIndex = 6;
            this.rb_en.TabStop = false;
            this.rb_en.Tag = "LanguageOption";
            this.rb_en.Text = "English อังกฤษ";
            this.rb_en.CheckedChanged += new System.EventHandler(this.LanguageCheckedChanged);
            // 
            // rb_th
            // 
            this.rb_th.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rb_th.Location = new System.Drawing.Point(115, 3);
            this.rb_th.Name = "rb_th";
            this.rb_th.Size = new System.Drawing.Size(111, 20);
            this.rb_th.TabIndex = 12;
            this.rb_th.TabStop = false;
            this.rb_th.Tag = "LanguageOption";
            this.rb_th.Text = "Thai ภาษาไทย";
            // 
            // lblChoose
            // 
            this.lblChoose.Location = new System.Drawing.Point(3, 6);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(100, 20);
            this.lblChoose.Text = "Choose language";
            // 
            // LanguageBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.rb_th);
            this.Controls.Add(this.rb_zh);
            this.Controls.Add(this.rb_ja);
            this.Controls.Add(this.rb_ko);
            this.Controls.Add(this.rb_vi);
            this.Controls.Add(this.rb_ru);
            this.Controls.Add(this.rb_en);
            this.Name = "LanguageBoard";
            this.Size = new System.Drawing.Size(234, 106);
            this.ParentChanged += new System.EventHandler(this.LanguageBoard_ParentChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_zh;
        private System.Windows.Forms.RadioButton rb_ja;
        private System.Windows.Forms.RadioButton rb_ko;
        private System.Windows.Forms.RadioButton rb_vi;
        private System.Windows.Forms.RadioButton rb_ru;
        private System.Windows.Forms.RadioButton rb_en;
        private System.Windows.Forms.RadioButton rb_th;
        private System.Windows.Forms.Label lblChoose;
    }
}
