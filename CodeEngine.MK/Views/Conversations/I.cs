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
    public partial class I : Form
    {
        public I()
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
                btnI1,
                btnI2,
                btnI3,
                btnI4,
                btnI5
            );
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this);
        }

        private void OnNavigate(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnI1" :
                    Program.SwitchView(this, new I1());
                    break;
                case "btnI2":
                    Program.SwitchView(this, new I2());
                    break;
                case "btnI3":
                    Program.SwitchView(this, new I3());
                    break;
                case "btnI4":
                    Program.SwitchView(this, new I4());
                    break;
                case "btnI5":
                    Program.SwitchView(this, new I5());
                    break;
            }
        }

    }
}