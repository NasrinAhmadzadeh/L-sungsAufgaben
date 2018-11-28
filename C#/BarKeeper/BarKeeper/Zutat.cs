using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarKeeper
{
   public  class Zutat
    {
        public List<Getränk> GetränkeList { get; set; }
        public List<Frucht> FrüchteList { get; set; }
        public string Name { get; set; }
    }
}
