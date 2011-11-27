using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CodeEngine.MK.Models;

namespace CodeEngine.MK.Views.Conversations
{
    public partial class I1 : Form
    {
        public I1()
        {
            InitializeComponent();
            this.LoadText();
            mnuCurrentLanguage.Text = Program.Language;
        }

        private void LoadText()
        {
            string tag = "I 1Conver(Time)";


            txtQuestion.Tag = new RequestObject(string.Empty, tag)
            {
                FixLanguage = Program.FixLanguage
            };

            txtAnswer2.Tag = new RequestObject(string.Empty, tag)
            {
                FixLanguage = Program.FixLanguage
            };
            cmbSelector.Tag = new RequestObject(string.Empty, tag,"question");
            cmbSelector2.Tag = new RequestObject(string.Empty, tag,"answer");

            LanguageManager.LoadLabels(
                new string[] { tag },
                lblAnswer2,
                lblHead,
                lblQuestion,
                lblSelector,
                lblSelector2
                );
            LanguageManager.LoadDataToCombobox(cmbSelector);
            LanguageManager.LoadDataToCombobox(cmbSelector2);
        }

        private void cmbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageManager.LoadTextByKey(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtQuestion
                );
        }

        private void cmbSelector2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageManager.LoadTextByKey(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtAnswer2
                );
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(SysViewer.ConversationMain);
        }
    }
}