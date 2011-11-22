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
    public partial class InformationIngredient : Form
    {


        public InformationIngredient()
        {
            InitializeComponent();
            //langBoard.OnLanguageChange += OnLanguageChange;

            LoadText();
        
        }

        private void LoadText()
        { 
            string[] zeroArray = new string[]{};
            lblIngredientInfo.Tag = new RequestObject("lblIngredientInfo", zeroArray);
            lblSelect.Tag = new RequestObject("lblSelect", "lblSelect");
            cmbIngredient.Tag = new RequestObject("cmbIngredient", "ingredient");
            //lblIngredientForOfficer.Tag = new RequestObject("lblIngredientForOfficer", zeroArray);
            txtIngridentOfficer.Tag = new RequestObject("txtIngridentOfficer", zeroArray);
            //lblIngredientForCustomer.Tag = new RequestObject("lblIngredientForCustomer", zeroArray);
            txtIngredientForCustomer.Tag = new RequestObject("txtIngredientForCustomer", zeroArray);


            LanguageManager.LoadTextToComboPrimary(cmbIngredient);
        
        }


        private void OnLanguageChange()
        { 
            //Load content here!!!
            //lblInformation.Tag = new RequestObject("lblInformation", new string[] { });
            //LanguageManager.LoadText(lblInformation);

        }

        private void txtIngredientForCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageManager.LoadTextByPrimary(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtIngridentOfficer,
                txtIngredientForCustomer
                );

        }


    }
}