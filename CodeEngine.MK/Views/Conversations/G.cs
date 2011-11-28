﻿using System;
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
    public partial class G : Form
    {
        public G()
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
                btnG3,
                btnG1,
                btnG2
                );
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this);
        }

        private void OnNavigate(object sender, EventArgs e)
        {

        }
    }
}