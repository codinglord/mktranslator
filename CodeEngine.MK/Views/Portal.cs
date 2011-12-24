using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CodeEngine.MK.Models;
using System.Diagnostics;
using CodeEngine.MK.Views.Informations;
using CodeEngine.MK.Views.Conversations;
using CodeEngine.MK.Views.Trainings;

namespace CodeEngine.MK.Views
{
    public partial class Portal : Form
    {
        public Portal()
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

        private void MainInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this,new InformationMain());
        }

        private void btnConversation_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this,new ConversationMain());
        }

        private void btnTraning_Click(object sender, EventArgs e)
        {
            Program.SwitchView(this,new TrainingMain());
        }

    }
}