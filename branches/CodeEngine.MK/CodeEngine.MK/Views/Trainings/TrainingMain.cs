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
    public partial class TrainingMain : Form
    {
        public TrainingMain()
        {
            InitializeComponent();
            langBoard.OnLanguageChange += OnLanguageChange;

            OnLanguageChange();

        }

        private void OnLanguageChange()
        {
            LanguageManager.LoadLabels(
                new string[] { this.Name },
                btnJ,
                btnK,
                btnMain,
                lblInformation,
                this
            );

        }

        private void OnNavigate(object sender, EventArgs e)
        {
            if (sender.Equals(btnJ))
            {
                Program.SwitchView(this, new J());
            }
            else if (sender.Equals(btnMain))
            {
                Program.SwitchView(this, Program._Portal);
            }
            else if (sender.Equals(btnK))
            {
                Program.SwitchView(this, new K());
            }
            else
            {
                throw new NotImplementedException((sender as Button).Name + " not implemented yet!");
            }
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }

    }
}