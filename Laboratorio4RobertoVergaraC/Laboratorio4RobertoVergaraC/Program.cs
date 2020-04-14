using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4RobertoVergaraC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a la fábrica de objetos!");
            Console.WriteLine("Seleccione lo que desee hacer");
            List<int> list = new List<int>();
            Computer computer = new Computer();
            Reception reception = new Reception();
            Storage storage = new Storage();
            Assembly assembly = new Assembly();
            Check check = new Check();
            Packing packing = new Packing();
            int contador = 1;
            while (contador != 0)
            {
                Console.WriteLine("\n(a) Prender Máquinas\n(b) Apagar Máquinas \n(c) Iniciar funcionamiento (empezaran a circular objetos por las máquinas) \n(d)\n(e)\n(f)\n(g) \n(h) \n(i) \n(j) Salir del programa\n");
                string option = Console.ReadLine();
                if (option == "a") 
                {
                    if (computer.Status == "ON") { Console.WriteLine("Las máquinas ya están prendidas"); }
                    else { computer.PowerON(reception, storage, assembly, check, packing); }
                }
                else if (option == "b") 
                {
                    if (computer.Status == "OFF") { Console.WriteLine("Las máquinas ya están apagadas"); }
                    else { computer.PowerOFF(reception, storage, assembly, check, packing); }
                }
                else if (option == "c") 
                {

                }
                else if (option == "d") 
                {
                }
                else if (option == "e") 
                {
                }
                else if (option == "f") 
                {
                }
                else if (option == "g") 
                {
                }
                else if (option == "h") 
                {
                }
                else if (option == "i") 
                {
                }
                else if (option == "j") //Salir del programa
                {
                    contador = 0;
                }
                else
                {
                    Console.WriteLine("\nLa opción que seleccionó no es válida, por favor escoga una que si lo sea");
                }
            }
        }
    }
}
