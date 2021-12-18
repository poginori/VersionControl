using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio2.Entities
{
   public  class Person
    {
        //születési év, nem, gyermekek száma.
        public int BirthYear { get; set; }
        public Gender Gender { get; set; }
        public int NrbOfChildren { get; set; }
        public bool IsAlive { get; set; }
        public Person()
        {
            IsAlive = true;
        }
    }
}
