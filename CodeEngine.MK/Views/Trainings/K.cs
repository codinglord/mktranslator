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
    public partial class K : Form
    {
        public K()
        {
            InitializeComponent();
            this.LoadText();
        }

        private void LoadText()
        {

            LanguageManager.LoadLabels(
                "{1}",
                new string[] { this.Name },
                lblHead,
                btnStep1,
                btnStep2,
                btnStep3,
                btnStep4,
                btnStep5,
                btnStep6,
                btnStep7
                );

        }
    }
}