using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratorio4RobertoVergaraC
{
    class Computer : Machines
    {
        private string status;

        public string Status { get => status; set => status = value; }

        public override bool restart()
        {
            return true;
        }

        public override string turnOff()
        {
            return "OFF";
        }

        public override string turnOn()
        {
            return "ON";
        }

        public void PowerON(Reception reception, Storage storage, Assembly assembly, Check check, Packing packing)
        {
            Console.WriteLine("Prendiendo máquina de recepción: " + reception.turnOn());
            Thread.Sleep(2000);
            Console.WriteLine("Prendiendo máquina de almacenamiento: " + storage.turnOn());
            Thread.Sleep(2000);
            Console.WriteLine("Prendiendo máquina de ensamblaje: " + assembly.turnOn());
            Thread.Sleep(2000);
            Console.WriteLine("Prendiendo máquina de verificación: " + check.turnOn());
            Thread.Sleep(2000);
            Console.WriteLine("Prendiendo máquina de verificación: " + check.turnOn());
            Thread.Sleep(2000);
            Console.WriteLine("Prendiendo máquina de empaque: " + packing.turnOn());
            Status = "ON";
        }

        public void PowerOFF(Reception reception, Storage storage, Assembly assembly, Check check, Packing packing)
        {
            Console.WriteLine("Apagando máquina de recepción: " + reception.turnOff());
            Thread.Sleep(2000);
            Console.WriteLine("Apagando máquina de almacenamiento: " + storage.turnOff());
            Thread.Sleep(2000);
            Console.WriteLine("Apagando máquina de ensamblaje: " + assembly.turnOff());
            Thread.Sleep(2000);
            Console.WriteLine("Apagando máquina de verificación: " + check.turnOff());
            Thread.Sleep(2000);
            Console.WriteLine("Apagando máquina de verificación: " + check.turnOff());
            Thread.Sleep(2000);
            Console.WriteLine("Apagando máquina de empaque: " + packing.turnOff());
            Status = "OFF";
        }
    }
}
