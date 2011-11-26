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
    public partial class InformationAboutMk : Form
    {
        public InformationAboutMk()
        {
            InitializeComponent();
            this.LoadText();
        }

        private void LoadText()
        {
            string tag = "C-เกี่ยวกับ Mk";

            
            txtAboutForOfficer.Tag = new RequestObject(string.Empty, tag, "question");
            txtAboutForCustomer.Tag = new RequestObject(string.Empty, tag, "answer");
            cmbSelector.Tag = new RequestObject(string.Empty, tag);

            LanguageManager.LoadLabels(
                new string[] { tag },
                lblAboutForCustomer,
                lblAboutForOfficer,
                lblAboutInfo,
                lblAboutSelect
                );
            LanguageManager.LoadDataToCombobox(cmbSelector);
        }

        private void cmbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageManager.LoadTextByKey(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtAboutForOfficer,
                txtAboutForCustomer
                );
        }

    }
}