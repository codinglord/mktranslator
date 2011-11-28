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
    public partial class J : Form
    {
        public J()
        {
            InitializeComponent();
            this.LoadText();
        }

        private void LoadText()
        {

            LanguageManager.LoadLabels(
                "{0} [{1}]",
                new string[] { this.Name },
                lblHead,
                btnDescribing,
                btnLaw,
                btnPlace,
                btnPopular,
                btnSayingWord,
                btnTime
                );

        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }



    }
}