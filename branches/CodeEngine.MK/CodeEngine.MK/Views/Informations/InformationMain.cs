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
    public partial class InformationMain : Form
    {
        public InformationMain()
        {
            InitializeComponent();
            langBoard.OnLanguageChange += OnLanguageChange;

            OnLanguageChange();

        }

        private void OnLanguageChange()
        {
            LanguageManager.LoadLabels(
                            new string[] { this.Name },
                            btnB,
                            btnC,
                            btnE,
                            btnMain,
                            lblInformation,
                            this
                        );

        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }

        private void OnNavigate(object sender, EventArgs e)
        {
            Button btnIssue = sender as Button;
            switch (btnIssue.Name)
            {
                case "btnB":
                    Program.SwitchView(this,new B());
                    break;
                case "btnC":
                    Program.SwitchView(this, new C());
                    break;
                case "btnE":
                    Program.SwitchView(this, new B());
                    break;
                case "btnMain":
                    Program.SwitchView(this, new E());
                    break;
            }
        }
    }
}