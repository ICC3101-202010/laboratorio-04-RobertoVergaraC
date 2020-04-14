using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            int contador2 = 1;
            Console.WriteLine("Antes de mostrar el menú, quiero señalar que la memoria de las máquinas son 3,4,5,6 y 7 respectivamante, por lo que si quiere que se reestablezca alguna memoria se tendran que procesar por lo menos 3 objetos");
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
                    while (contador != 0)
                    {
                        if (computer.Status == "OFF")
                        {
                            Console.WriteLine("No puede comenzar el funcionamiento ya que las máquinas están apagadas");
                            break;
                        }
                        list.Add(contador2);
                        Console.WriteLine("Procesando Objeto " + contador2);
                        reception.restart();
                        storage.restart();
                        assembly.restart();
                        check.restart();
                        packing.restart();
                        contador2++;
                        string continuar = "";
                        while (continuar != "STOP")
                        {
                            Console.WriteLine("Desea Continuar ( (si) (no) ) ");
                            continuar = Console.ReadLine();
                            if (continuar == "si") { continuar = "STOP"; }
                            else if (continuar == "no")
                            {
                                contador = 0;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nLa opción que seleccionó no es válida, por favor escoga una que si lo sea");
                            }
                        }
                    }
                    contador = 1;
                }
                else if (option == "d")
                {
                    if (computer.Status == "OFF")
                    {
                        Console.WriteLine("No puede comenzar el funcionamiento ya que las máquinas están apagadas");
                        contador = 0;
                    }
                    else
                    {
                        list.Clear();
                        contador2 = 0;
                    }
                    while (contador !=0)
                    {
                        list.Add(contador2);
                        Console.WriteLine("Procesando Objeto " + contador2);
                        reception.restart();
                        storage.restart();
                        assembly.restart();
                        check.restart();
                        packing.restart();
                        contador2++;
                        string continuar = "";
                        while (continuar != "STOP")
                        {
                            Console.WriteLine("Desea Continuar ( (si) (no) ) ");
                            continuar = Console.ReadLine();
                            if (continuar == "si") { continuar = "STOP"; }
                            else if (continuar == "no")
                            {
                                contador = 0;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nLa opción que seleccionó no es válida, por favor escoga una que si lo sea");
                            }
                        }
                    }
                    contador = 1;
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
