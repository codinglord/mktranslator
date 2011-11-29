using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using A1 = CodeEngine.MK.Data.AppDBDataSet;
using CodeEngine.MK.Data.AppDBDataSetTableAdapters;
using System.Data;
using System.Text.RegularExpressions;

namespace CodeEngine.MK.Models
{
    static class LanguageManager
    {

        private static DataDictionaryTableAdapter _Adapter { get; set; }
        private static A1.DataDictionaryDataTable _Cached{get; set;}


        static LanguageManager()
        {
            LanguageManager._Adapter = new DataDictionaryTableAdapter();
            _Cached = _Adapter.GetData();
        }


        [Obsolete()]
        public static void LoadText(List<LanguageMapper> mappers)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Cached;
            var rows = tbl.Where(f => mappers.Select(k => k.Key).ToArray().Contains(f.Key));
            foreach (var i in mappers)
            {
                i.Ctrl.Text = rows.First(f => f.Key == i.Key)[i.Language].ToString();
            }            
        }

        public static void LoadText(params Control[] controls)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Cached;
            var rows = tbl.Where(f => controls  .Select(k => (k.Tag as RequestObject).Key.ToLower().Trim())
                                                .ToArray()
                                                .Contains(f.Key.ToLower().Trim()));
            foreach (var i in controls)
            {
                RequestObject iReq = i.Tag as RequestObject;
                i.Text = rows.First(f => f.Key.ToLower() == iReq.Key.ToLower())[iReq.Language].ToString();
            }
        }

        public static void LoadDataToCombobox(ComboBox control)
        {
            if (control.Items.Count != 0)
            {
                control.Items.Clear();
            }

            RequestObject req = control.Tag as RequestObject;
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Cached;
            var rows = tbl.Where(
                f =>  req.Tags.TrueForAll(d => f.Tags.Split(',').Select(s => s.Trim()).Contains(d))  
                && (string.IsNullOrEmpty(req.Key) || f.Key == req.Key)
                )
                .Select(f => new ItemObject(f[req.Language].ToString(), f.Key));

            foreach (var i in rows)
            {
                control.Items.Add(i);
            }
            
        }

        public static void LoadTextByKey(string key,params Control[] controls)
        {

            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Cached;
            foreach (var i in controls)
            {
                RequestObject req = i.Tag as RequestObject;
                var rows = tbl.FirstOrDefault(f =>
                        req.Prefix + f.Key.Trim() == req.Prefix + key.Trim()
                        && 
                        (
                            req.Tags.Count == 0
                            ||
                            req.Tags.TrueForAll(
                                k => f.Tags.Split(',').Select(s => s.Trim()).Contains(k.Trim())
                            )
                        )
                    );

                if (rows != null)
                {
                    i.Text = rows[req.Language].ToString();
                }
                else
                {
                    i.Text = "No text was found!";
                }
            }
            
        }

        public static void LoadLabels(string[] tags, params Control[] controls)
        {
            foreach (var i in controls)
            {
                RequestObject iRequestObject = new RequestObject(
                    i.Name, Program.ZeroArrayString
                );
                iRequestObject.Tags.Add("label");
                iRequestObject.Tags.AddRange(tags);
                i.Tag = iRequestObject;
                var iRow = _Cached.FirstOrDefault(f => f.Key.Trim() == i.Name.Trim()
                    &&
                    (tags.Length == 0 || Array.TrueForAll(tags, k => f.Tags.Split(',').Select(d => d.Trim()).Contains(k.Trim())))
                    );
                if (iRow != null)
                {
                    i.Text = iRow[iRequestObject.Language].ToString();
                }
                else
                {
                    i.Text = string.Format("{0} was not found!", i.Name);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="displayText">{0} = dynamic {1} = fixed.</param>
        /// <param name="tags"></param>
        /// <param name="controls"></param>
        public static void LoadLabels(string patternText,string[] tags,params Control[] controls)
        {
            foreach (var i in controls)
            {
                RequestObject iRequestObject = new RequestObject(
                    i.Name,Program.ZeroArrayString
                ) ;
                iRequestObject.Tags.Add("label");
                iRequestObject.Tags.AddRange(tags);
                i.Tag = iRequestObject;
                var iRow = _Cached.FirstOrDefault(f => f.Key.Trim() == i.Name.Trim() 
                    &&
                    (tags.Length == 0 || Array.TrueForAll(tags,k => f.Tags.Split(',').Select(d => d.Trim()).Contains(k.Trim())))
                    );
                if (iRow != null)
                {

                    i.Text = string.Format(patternText,
                        iRow[iRequestObject.Language].ToString(),
                        iRow[Program.FixLanguage].ToString()
                        );
                }
                else
                {
                    i.Text = string.Format("{0} was not found!", i.Name);
                }
            }
        }

        public static A1.DataDictionaryRow[] GetTextByGroup(string tag, string language)
        {
            CodeEngine.MK.Data.AppDBDataSet.DataDictionaryDataTable tbl = _Cached;
            var rows = tbl.Where(
                    f => f  .Tags
                            .Split(',')
                            .Select(k => k.Trim().ToLower())
                            .Contains(tag.Trim().ToLower()));
            return rows.ToArray();
        }

    }
}
