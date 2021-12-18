using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio2.Entities
{
    public class DeathProbabilities
    {
        //A szükséges tulajdonságok: nem, kor és a halálozási valószínűség (P - double)
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public double P { get; set; }
    }
}
