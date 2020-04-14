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
            int contador2 = 0;
            while (true)
            {
                Console.WriteLine("\n(a) Prender Máquinas\n(b) Apagar Máquinas \n(c) Iniciar funcionamiento (empezaran a circular objetos por las máquinas) / Continuar funcionamiento \n(d) Iniciar funcionamiento denuevo desde '0' (Se borrará el funcionamiento que llevaba hasta ese momento) \n(e) Salir del programa\n");
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
                    while (true)
                    {
                        if (computer.Status == "OFF") 
                        {
                            Console.WriteLine("No puede comenzar el funcionamiento ya que las m+aquinas están apagadas");
                            break;
                        }
                        list.Add(contador2);
                        reception.Restarting();
                        storage.Restarting();
                        assembly.Restarting();
                        check.Restarting();
                        packing.Restarting();
                    }
                }
                else if (option == "d") 
                {
                    while (true)
                    {
                        if (computer.Status == "OFF")
                        {
                            Console.WriteLine("No puede comenzar el funcionamiento ya que las m+aquinas están apagadas");
                            break;
                        }
                        else { list.Clear(); }
                        list.Add(contador2);
                        reception.Restarting();
                        storage.Restarting();
                        assembly.Restarting();
                        check.Restarting();
                        packing.Restarting();
                    }
                }
                else if (option == "e") //Salir del programa
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nLa opción que seleccionó no es válida, por favor escoga una que si lo sea");
                }
            }
        }
    }
}
