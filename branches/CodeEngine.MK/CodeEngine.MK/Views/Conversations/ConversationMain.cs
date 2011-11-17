using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeEngine.MK.Views.Conversations
{
    public partial class ConversationMain : Form
    {
        public ConversationMain()
        {
            InitializeComponent();
            langBoard.OnLanguageChange += OnLanguageChange;
        }

        private void OnLanguageChange()
        { 
            //Load content here!!!
            //lblInformation.Tag = new RequestObject("lblInformation", new string[] { });

            //btnInformation.Tag = new RequestObject("");

            //LanguageManager.LoadText(lblInformation);
        }

        private void OnNavigate(object sender, EventArgs e)
        {
            Button issuer = sender as Button;
            if (issuer.Equals(btnAccquire))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationAccquire);
            }
            else if (issuer.Equals(btnAskMap))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationAskMap);
            }
            else if (issuer.Equals(btnAskPrice))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationAskPrice);
            }
            else if (issuer.Equals(btnConversationEtc))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationEtc);
            }
            else if (issuer.Equals(btnMain))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.Portal);
            }
            else if (issuer.Equals(btnRecommendMenu))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationRecommendMenu);
            }
            else
            {
                throw new NotImplementedException(issuer.Name);
            }

        }

    }
}