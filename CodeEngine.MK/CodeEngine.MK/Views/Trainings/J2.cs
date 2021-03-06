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
    public partial class J2 : Form
    {
        public J2()
        {
            InitializeComponent();
            this.LoadText();
            mnuCurrentLanguage.Text = Program.Language;
        }

        private void LoadText()
        {
            string tag = "J 2คำศัพท์(อุปกรณ์ทาน)";


            txtQuestion.Tag = new RequestObject(string.Empty, tag, "question")
            {
                FixLanguage = Program.FixLanguage
            };
            cmbSelector.Tag = new RequestObject(string.Empty, tag, "question");

            LanguageManager.LoadLabels(
                new string[] { this.Name },
                lblHead,
                lblQuestion,
                lblSelector,
                this
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

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this);
        }
    }
}