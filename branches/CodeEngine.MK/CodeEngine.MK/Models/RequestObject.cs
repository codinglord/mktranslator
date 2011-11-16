using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CodeEngine.MK.Models
{
    class RequestObject
    {
        private string _Language;

        public string Key { get; set; }
        public List<string> Tags { get; set; }
        public string Language 
        {
            get
            {
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

        public RequestObject(string key,params string[] tags)
        {
            this.Key = key;
            this.Tags = new List<string>(tags);
        }

    }
}
