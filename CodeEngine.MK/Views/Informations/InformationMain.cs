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
        }

        private void OnLanguageChange()
        { 
            //Load content here!!!
            lblInformation.Tag = new RequestObject("lblInformation", new string[] { });
            LanguageManager.LoadText(lblInformation);

        }

        private void OnNavigate(object sender, EventArgs e)
        {
            Button issuer = sender as Button;
            if (issuer.Equals(btnAboutMK))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.InformationAboutMk);
            }
            else if (issuer.Equals(btnAskMember))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.InformationAskMember);
            }
            else if (issuer.Equals(btnIngredient))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.InformationIngredient);
            }
            else if (issuer.Equals(btnMain))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.Portal);
            }
            else
            {
                throw new NotImplementedException(issuer.Name+" not implemented yet!");
            }
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }
    }
}