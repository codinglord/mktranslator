using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeEngine.MK.Views.Trainings
{
    public partial class TrainingMain : Form
    {
        public TrainingMain()
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
            if (sender.Equals(btnVocaburary))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.J);
            }
            else if (sender.Equals(btnMain))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.Portal);
            }
            else if (sender.Equals(btnConversation))
            {
                Program.SwitchView(CodeEngine.MK.Models.SysViewer.K);
            }
            else
            {
                throw new NotImplementedException((sender as Button).Name + " not implemented yet!");
            }
        }

    }
}