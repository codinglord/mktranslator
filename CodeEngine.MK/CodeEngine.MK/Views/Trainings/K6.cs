using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CodeEngine.MK.Models;

namespace CodeEngine.MK.Views.Trainings
{
    public partial class K6 : Form
    {
        public K6()
        {
            InitializeComponent();
            this.LoadText();
            mnuCurrentLanguage.Text = Program.Language;
        }

        private void LoadText()
        {
            string tag = "K 6เก็บเงิน";


            txtQuestion.Tag = new RequestObject(string.Empty, tag)
            {
                FixLanguage = Program.FixLanguage
            };
            txtRead.Tag = new RequestObject("karaoke", tag);
            cmbSelector.Tag = new RequestObject(string.Empty, tag);

            LanguageManager.LoadLabels(
                new string[] { this.Name },
                lblHead,
                lblQuestion,
                lblSelector,
                lblRead,
                this
                );
            LanguageManager.LoadDataToCombobox(cmbSelector);
        }

        private void cmbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageManager.LoadTextByKey(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtQuestion,
                txtRead
                );
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this);
        }
    }
}