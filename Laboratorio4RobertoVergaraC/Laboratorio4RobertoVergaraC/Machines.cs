using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4RobertoVergaraC
{
    public abstract class Machines
    {
        protected int Memory = 10;
        public abstract string turnOn();
        public abstract string turnOff();
        public abstract bool restart();
    }
}
