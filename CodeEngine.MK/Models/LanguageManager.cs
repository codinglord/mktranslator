using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using A1 = CodeEngine.MK.Data.AppDBDataSet;
using CodeEngine.MK.Data.AppDBDataSetTableAdapters;

namespace CodeEngine.MK.Models
{
    static class LanguageManager
    {

        private static DataDictionaryTableAdapter _Adapter { get; set; }

        static LanguageManager()
        {
            LanguageManager._Adapter = new DataDictionaryTableAdapter();
        }

        public static void LoadText(List<LanguageMapper> mappers)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Adapter.GetData();
            var rows = tbl.Where(f => mappers.Select(k => k.Key).ToArray().Contains(f.Key));
            foreach (var i in mappers)
            {
                i.Ctrl.Text = rows.First(f => f.Key == i.Key)[i.Language].ToString();
            }            
        }

        public static A1.DataDictionaryRow[] GetTextByGroup(string tag, string language)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Adapter.GetData();
            var rows = tbl.Where(
                    f => f  .Tags
                            .Split(',')
                            .Select(k => k.Trim())
                            .Contains(tag.Trim()));
            return rows.ToArray();
        }

    }
}
