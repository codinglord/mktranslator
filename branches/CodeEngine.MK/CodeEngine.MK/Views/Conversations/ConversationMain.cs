﻿using System;
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
            switch (issuer.Name)
            {
                case "btnI" :
                    Program.SwitchView(this,new I());
                    break;
                case "btnD":
                    Program.SwitchView(this, new D());
                    break;
                case "btnG":
                    Program.SwitchView(this, new G());
                    break;
                case "btnF":
                    Program.SwitchView(this, new F());
                    break;
                case "btnH":
                    Program.SwitchView(this, new H());
                    break;
                case "btnMain":
                    Program.SwitchView(this, Program._Portal);
                    break;
            }

        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }

    }
}