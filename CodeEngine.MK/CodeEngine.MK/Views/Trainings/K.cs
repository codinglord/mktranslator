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
                btnK1,
                btnK2,
                btnK3,
                btnK4,
                btnK5,
                btnK6,
                btnK7,
                this
                );

        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }

        private void OnNavigate(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnK1" :
                    Program.SwitchView(this, new K1());
                    break;
                case "btnK2":
                    Program.SwitchView(this, new K2());
                    break;
                case "btnK3":
                    Program.SwitchView(this, new K3());
                    break;
                case "btnK4":
                    Program.SwitchView(this, new K4());
                    break;
                case "btnK5":
                    Program.SwitchView(this, new K5());
                    break;
                case "btnK6":
                    Program.SwitchView(this, new K6());
                    break;
                case "btnK7":
                    Program.SwitchView(this, new K7());
                    break;
            }
        }

    }
}