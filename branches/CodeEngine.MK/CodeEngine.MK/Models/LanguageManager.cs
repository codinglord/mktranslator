using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CodeEngine.MK.Data.AppDBDataSetTableAdapters;

namespace CodeEngine.MK.Models
{
    static class LanguageManager
    {

        private static DictionaryDetailTableAdapter DictionaryDetail { get; set; }

        static LanguageManager()
        {
            LanguageManager.DictionaryDetail = new DictionaryDetailTableAdapter();
        }

        public static void LoadText(List<LanguageMapper> mappers)
        {
            CodeEngine.MK.Data.AppDBDataSet.DictionaryDetailDataTable tbl = DictionaryDetail.GetData();
            foreach (LanguageMapper i in mappers)
            {
                var rows = tbl.Where(f => {
                    string fKey = f["Key"].ToString();
                    string fLanguage = f["Language"].ToString();
                    return fKey == i.Key && fLanguage == i.Language;
                });
                foreach (var j in rows)
                {
                    i.Ctrl.Text = j["Value"].ToString();
                }
            }
        }

    }
}
