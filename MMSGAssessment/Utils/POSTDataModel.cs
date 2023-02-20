using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSGAssessment.Utils
{
    public class POSTDataModel
    {
        public string name { get; set; }
        public string job { get; set; }
    }

    public class Rootobject
    {
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
    }

}
