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
            Program.Language = (sender as Control).Name.Split('_')[1];
            OnLanguageChange.Invoke();
        }

        private void LanguageBoard_Click(object sender, EventArgs e)
        {

        }

        private void rb_ja_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
