using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4RobertoVergaraC
{
    class Storage : Machines, IRestartingMemory
    {
        int counter = 0;

        public void Restarting()
        {
            counter = 0;
        }

        public override bool restart()
        {
            if (counter == Memory)
            {
                Restarting();
                return true;
            }
            return false;
        }

        public override string turnOff()
        {
            return "OFF";
        }

        public override string turnOn()
        {
            return "ON";
        }
    }
}
