using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio2.Entities
{
    public class BirthProbabilities
    {
        //A szükséges tulajdonságok: kor, gyermekek száma és a valószínűség (P - double)
        public int Age { get; set; }
        public int NrbOfChildren { get; set; }
        public double P { get; set; }
    }
}
