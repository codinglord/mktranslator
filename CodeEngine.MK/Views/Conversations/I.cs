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
                btnDescribing,
                btnLaw,
                btnPlace,
                btnPopularConversation,
                btnSaying,
                btnTime
            );
        }
    }
}