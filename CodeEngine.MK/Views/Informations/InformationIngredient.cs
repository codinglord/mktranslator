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
            lblIngredientInfo.Tag = new RequestObject("lblIngredientInfo", Program.ZeroArrayString);
            lblSelect.Tag = new RequestObject("lblSelect", "lblSelect");
            cmbIngredient.Tag = new RequestObject(string.Empty, "B-ส่วนผสมสินค้า") { UseKey = true };

            lblIngredientForOfficer.Tag = new RequestObject("lblIngredientForOfficer", Program.ZeroArrayString) {FixLanguage = "th"};
            txtIngridentOfficer.Tag = new RequestObject(string.Empty, "B-ส่วนผสมสินค้า") { FixLanguage = "th" };

            lblIngredientForCustomer.Tag = new RequestObject("lblIngredientForCustomer", Program.ZeroArrayString);
            txtIngredientForCustomer.Tag = new RequestObject(string.Empty, "B-ส่วนผสมสินค้า");
            

            LanguageManager.LoadDataToCombobox(cmbIngredient);        
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
            LanguageManager.LoadTextByKey(
                ((sender as ComboBox).SelectedItem as ItemObject).ValueOfKey.ToString(),
                txtIngridentOfficer,
                txtIngredientForCustomer
                );

        }

        private void mnuChangeLanguage_Click(object sender, EventArgs e)
        {

        }


    }
}