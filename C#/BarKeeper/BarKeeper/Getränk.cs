using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarKeeper
{
   public  class Getränk
    {
        public string Name { get; set; }
        public GetränkeTypeEnum Type { get; set; }
        public double verfügbareMenge { get; set; }

    }
}
