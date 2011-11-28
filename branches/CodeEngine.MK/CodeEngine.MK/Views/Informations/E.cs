using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CodeEngine.MK.Models;

namespace CodeEngine.MK.Views.Informations
{
    public partial class E : Form
    {
        public E()
        {
            InitializeComponent();
            this.LoadText();
        }

        private void LoadText()
        {
            string tag = "E-สมาชิก MK";


            txtQuestion.Tag = new RequestObject(string.Empty, tag, "question");
            txtAnswer.Tag = new RequestObject(string.Empty, tag, "answer");
            cmbSelector.Tag = new RequestObject(string.Empty, tag);

            LanguageManager.LoadLabels(
                new string[] { tag },
                lblAskMemberForCustomer,
                lblAskMemberForOfficer,
                lblAskMemberInfo,
                lblAskMemberSelect
                );
            LanguageManager.LoadDataToCombobox(cmbSelector);
        }

        private void cmbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageManager.LoadTextByKey(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtQuestion,
                txtAnswer
                );
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }
    }
}