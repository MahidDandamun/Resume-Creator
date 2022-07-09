using System;
using System.Collections.Generic;
using System.Text;

namespace JSONfileReceiver
{
    class JSONdecoder
    {
        public string FullName { get; set; }
       
        public string ContactInfo { get; set; }
        public string Profile { get; set; }
        public string Objective { get; set; }
        public string Education   { get; set; } //An array
        public string SKILLS { get; set; } //An array
        public string WORKHISTORY { get; set; } //An array
        
    }
}
