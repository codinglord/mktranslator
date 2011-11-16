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



            langBoard.OnLanguageChange += OnLanguageChange;

        }

        private void OnLanguageChange()
        { 
            //Load content here!!!
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