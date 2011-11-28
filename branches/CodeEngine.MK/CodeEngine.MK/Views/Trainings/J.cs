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
                btnJ1,
                btnJ2,
                btnJ3,
                btnJ4,
                btnJ5
                );

        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {

        }

        private void OnNavigate(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnJ1":
                    Program.SwitchView(this, new J1());
                    break;
                case "btnJ2":
                    Program.SwitchView(this, new J2());
                    break;
                case "btnJ3":
                    Program.SwitchView(this, new J3());
                    break;
                case "btnJ4":
                    Program.SwitchView(this, new J4());
                    break;
                case "btnJ5":
                    Program.SwitchView(this, new J5());
                    break;
            }
        }





    }
}