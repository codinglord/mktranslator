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
    public partial class ConversationEtc : Form
    {
        public ConversationEtc()
        {
            InitializeComponent();
        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this);
        }
    }
}