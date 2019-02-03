using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections;

namespace Gaffgc_App
{
    public class DNA
    {
        [Key]
        public int id { get; set; }
        public string barCode { get; set; }
        public bool hasMatch { get; set; }
        public string store_url { get; set; }
        public string location { get; set; }

        public IEnumerable<String> sequence { get; set; }
        public Dictionary<string, string> compliment { get; set; }

        public void longestCommon(string s1, string s2)
        {
            IEnumerator it = sequence.GetEnumerator();
            while(it.MoveNext())
            {
            }
        }

    }
}