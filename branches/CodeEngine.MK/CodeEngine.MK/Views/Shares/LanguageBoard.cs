using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CodeEngine.MK.Models;

namespace CodeEngine.MK.Views
{

    public delegate void CallbackControlChanged();

    public partial class LanguageBoard : UserControl
    {
        public LanguageBoard()
        {
            InitializeComponent();
        }

        public event CallbackControlChanged OnLanguageChange;

        private void LanguageCheckedChanged(object sender, EventArgs e)
        {
            string changedLang = (sender as Control).Name.Split('_')[1];
            if (Program.Language != changedLang)
            try
            {
                Program.Language = changedLang;
                OnLanguageChange.Invoke();
            }
            catch (Exception){}
        }

        private void LanguageBoard_ParentChanged(object sender, EventArgs e)
        {
            switch (Program.Language)
            {
                //case "th":
                //    rb_th.Checked = true;
                //    break;
                case "en":
                    rb_en.Checked = true;
                    break;
                case "ko":
                    rb_ko.Checked = true;
                    break;
                case "ru":
                    rb_ru.Checked = true;
                    break;
                case "ja":
                    rb_ja.Checked = true;
                    break;
                case "zh":
                    rb_zh.Checked = true;
                    break;
                case "vi":
                    rb_vi.Checked = true;
                    break;
                default:
                    throw new Exception("Unexpected language = " + Program.Language + "!");
            }
        }


    }
}
