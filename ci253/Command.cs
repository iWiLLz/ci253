using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci253
{
    class Command
    {
        public string CommandWord { get; set; }
        public string SecondWord { get; set; }
        public string ThirdWord { get; set; }
        public Boolean IsUnkown { get { return (CommandWord == null); } }
    }
}
