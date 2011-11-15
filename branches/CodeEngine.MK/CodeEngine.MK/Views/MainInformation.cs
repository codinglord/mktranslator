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

namespace CodeEngine.MK.Views
{
    public partial class MainInformation : Form
    {
        public MainInformation()
        {
            InitializeComponent();
        }

        private void LanguageCheckedChanged(object sender, EventArgs e)
        {
            Program.Language = (sender as Control).Name.Split('_')[1];


            List<LanguageMapper> langMappers = new List<LanguageMapper>();


            #region Controls

            langMappers.Add(new LanguageMapper()
            {
                Key = btnAbout.Tag.ToString(),
                Language = Program.Language,
                Ctrl = btnAbout
            });

            langMappers.Add(new LanguageMapper()
            {
                Key = btnAsk.Tag.ToString(),
                Language = Program.Language,
                Ctrl = btnAsk
            });

            langMappers.Add(new LanguageMapper()
            {
                Key = btnIngredient.Tag.ToString(),
                Language = Program.Language,
                Ctrl = btnIngredient
            });

            langMappers.Add(new LanguageMapper()
            {
                Key = btnMain.Tag.ToString(),
                Language = Program.Language,
                Ctrl = btnMain
            });

            langMappers.Add(new LanguageMapper()
            {
                Key = lblInformation.Tag.ToString(),
                Language = Program.Language,
                Ctrl = lblInformation
            });

            #endregion Controls

            LanguageManager.LoadText(langMappers);

        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnAsk_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {

        }

        private void MainInformation_Load(object sender, EventArgs e)
        {

        }

    }
}