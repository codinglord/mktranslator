using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CodeEngine.MK.Models
{
    class RequestObject
    {
        private string _FixLanguage;
        private string _Language;

        public string FixLanguage 
        {
            get
            {
                return _FixLanguage;
            }
            set
            {
                _FixLanguage = value;
            }
        }
        public string Prefix { get; set; }
        public bool UseKey { get; set; }
        public string Key { get; set; }
        public List<string> Tags { get; set; }
        public string Language 
        {
            get
            {
                if (UseKey)
                {
                    return "Key";
                }
                else if (!String.IsNullOrEmpty(_FixLanguage))
                {
                    return _FixLanguage;
                }
                if (string.IsNullOrEmpty(_Language))
                {
                    return Program.Language;
                }
                else
                {
                    return _Language;
                }
            }
            set
            {
                _Language = value;
            }
        }

        public void SetFixLanguage(string lang)
        {
            this._FixLanguage = lang;
        }

        public RequestObject(string key,params string[] tags)
        {
            this.Prefix = string.Empty;
            this.Key = key;
            this.Tags = new List<string>(tags);
        }

    }
}
