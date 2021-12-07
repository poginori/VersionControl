using Programtervezésminta.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programtervezésminta.Entities
{
    class CarFactory : IToyFactory
    {
        public Toy Createnew()
        {
            return new Car();
        }
    }
}
