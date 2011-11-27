﻿using System;
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
    public partial class K1 : Form
    {
        public K1()
        {
            InitializeComponent();
            this.LoadText();
        }

        private void LoadText()
        {
            string tag = "K 1มาตรฐานสนทนา(Well Com)";


            txtQuestion.Tag = new RequestObject(string.Empty, tag)
            {
                FixLanguage = Program.FixLanguage
            };
            cmbSelector.Tag = new RequestObject(string.Empty, tag);

            LanguageManager.LoadLabels(
                new string[] { tag },
                lblHead,
                lblQuestion,
                lblSelector
                );
            LanguageManager.LoadDataToCombobox(cmbSelector);
        }

        private void cmbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageManager.LoadTextByKey(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtQuestion
                );
        }
    }
}