using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarKeeperDB
{
    public class FruchtZutat
    {
        public int ID { get; set; }
        public int FruchtId { get; set; }
        public int ZutatId { get; set; }
        public int Stueck { get; set; }

    }
}
