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
    public partial class D : Form
    {
        public D()
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
                btnD1,
                btnD3,
                btnD5,
                btnD2,
                btnD4
                );
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this);
        }

        private void OnNavigate(object sender, EventArgs e)
        {
            Button btnIssue = sender as Button;
            switch (btnIssue.Name)
            {
                case "btnD1" :
                    Program.SwitchView(this,new D1());
                    break;
                case "btnD2":
                    Program.SwitchView(this, new D1());
                    break;
                case "btnD3":
                    Program.SwitchView(this, new D1());
                    break;
                case "btnD4":
                    Program.SwitchView(this, new D1());
                    break;
                case "btnD5":
                    Program.SwitchView(this, new D1());
                    break;
            }
        }

    }

    

}