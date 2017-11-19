using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatate.UI
{
    public class TestItemModel
    {
        public string TestName { get; set; }
        public string Description {get;set;}
        public bool? IsSuccess { get; set; }
        public string Errors { get; set; }
    }
}
