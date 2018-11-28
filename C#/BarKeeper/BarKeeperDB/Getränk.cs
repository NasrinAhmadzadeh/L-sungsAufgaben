using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarKeeperDB
{
   public  class Getränk
    {
        public int ID { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public double GesamtMenge { get; set; }
        public string Beschreibung { get; set; }

    }
}
