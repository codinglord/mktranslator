using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using A1 = CodeEngine.MK.Data.AppDBDataSet;
using CodeEngine.MK.Data.AppDBDataSetTableAdapters;
using System.Data;

namespace CodeEngine.MK.Models
{
    static class LanguageManager
    {

        private static DataDictionaryTableAdapter _Adapter { get; set; }

        static LanguageManager()
        {
            LanguageManager._Adapter = new DataDictionaryTableAdapter();
        }

        [Obsolete()]
        public static void LoadText(List<LanguageMapper> mappers)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Adapter.GetData();
            var rows = tbl.Where(f => mappers.Select(k => k.Key).ToArray().Contains(f.Key));
            foreach (var i in mappers)
            {
                i.Ctrl.Text = rows.First(f => f.Key == i.Key)[i.Language].ToString();
            }            
        }

        public static void LoadText(params Control[] controls)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Adapter.GetData();
            var rows = tbl.Where(f => controls  .Select(k => (k.Tag as RequestObject).Key.ToLower().Trim())
                                                .ToArray()
                                                .Contains(f.Key.ToLower().Trim()));
            foreach (var i in controls)
            {
                RequestObject iReq = i.Tag as RequestObject;
                i.Text = rows.First(f => f.Key.ToLower() == iReq.Key.ToLower())[iReq.Language].ToString();
            }
        }

        public static void LoadTextToComboPrimary(ComboBox control)
        {
            if (control.Items.Count != 0)
            {
                control.Items.Clear();
            }

            RequestObject req = control.Tag as RequestObject;
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Adapter.GetData();
            var rows = tbl.Where(f => f.Tags.Split(',').Contains(req.Tags[0]) && !f.Key.StartsWith("_"))
                            .Select(f => new ItemObject(f[req.Language].ToString(), f.Key));

            foreach (var i in rows)
            {
                control.Items.Add(i);
            }
            
        }

        public static void LoadTextByPrimary(string key,params Control[] controls)
        {
            
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Adapter.GetData();
            string prefix = "_";
            foreach (var i in controls)
            {
                RequestObject req = i.Tag as RequestObject;
                var rows = tbl.FirstOrDefault(f => prefix + f.Key.Trim() == prefix + key.Trim());
                if (rows != null)
                {
                    i.Text = rows[req.Language].ToString();
                }
                else
                {
                    i.Text = "No text was found!";
                }
                prefix = "_" + prefix;
            }
            
        }

        public static A1.DataDictionaryRow[] GetTextByGroup(string tag, string language)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Adapter.GetData();
            var rows = tbl.Where(
                    f => f  .Tags
                            .Split(',')
                            .Select(k => k.Trim().ToLower())
                            .Contains(tag.Trim().ToLower()));
            return rows.ToArray();
        }

    }
}
