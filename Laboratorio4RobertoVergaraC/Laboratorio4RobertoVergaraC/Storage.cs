using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4RobertoVergaraC
{
    class Storage : Machines, IRestartingMemory
    {
        private int Memory = 4;
        int counter = 0;

        public void Restarting()
        {
            counter = 0;
        }

        public override bool restart()
        {
            counter++;
            if (counter == Memory)
            {
                Restarting();
                Console.WriteLine("La máquina de almacenamiento llegó a su capacidad máxima de memoria, por lo que se le reestablecerá");
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
