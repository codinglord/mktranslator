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
        }

        private void OnNavigate(object sender, EventArgs e)
        {
            Button issuer = sender as Button;
            if (issuer.Name == btnAccquire.Name)
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationAccquire);
            }
            else if (issuer.Name == btnAskMap.Name)
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationAskMap);
            }
            else if (issuer.Name == btnAskPrice.Name)
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationAskPrice);
            }
            else if (issuer.Name == btnConversationEtc.Name)
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.ConversationEtc);
            }
            else if (issuer.Name == btnMain.Name)
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.Portal);
            }
            else if (issuer.Name == btnRecommendMenu.Name)
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