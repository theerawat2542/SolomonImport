using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolomonImport
{
    public class SapTaglist
    {
        public string Ccode { get; set; }
        public string station { get; set; }
        public string line { get; set; }
        public string tagnumber { get; set; }
        public string wipid { get; set; }
        public string countdate { get; set; }
        public string item { get; set; }
        public string itemdescr { get; set; }
        public string unit { get; set; }
        public string type { get; set; }
        public string jobnumber { get; set; }
        public string productiondate { get; set; }
        public string ProcLineDecr { get; set; }
        public string BlankTag { get; set; }
        public string InvtType { get; set; }
    }
}
