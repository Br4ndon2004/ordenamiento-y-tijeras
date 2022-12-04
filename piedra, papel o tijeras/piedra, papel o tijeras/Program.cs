using System;

namespace Piedra_Papel_Tijera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("elige entre:piedra, papel o tijeras ");
                string op = Console.ReadLine().ToUpper();
                if (op == "sal")
                {
                    break;
                }
                if (op == "PIEDRA" || op == "PAPEL" || op == "TIJERA")
                {
                    Random rnd = new Random();
                    int randoomm = rnd.Next(0, 3);
                    string[] opc = new string[] { "PIEDRA", "PAPEL", "TIJERA" };
                    string machine = opc[randoomm];
                    Console.WriteLine("" + machine);
                    if (op == machine)
                    {
                        Console.WriteLine("iguales");
                    }
                    else if (op == "PIEDRA" && machine == "TIJERA")
                    {
                        Console.WriteLine("usted gano");
                    }
                      else if (op == "PAPEL" && machine == "PIEDRA")
                    {
                         Console.WriteLine("usted gano");
                    }
                       else if (op == "TIJERA" && machine == "PAPEL")
                    {
                          Console.WriteLine("usted gano");
                    }
                         else

                        Console.WriteLine("has perdido ));");
                    { 
                    }
                }
                else
                {
                    Console.WriteLine("error, tu eleccion no esta en la lista ):");
                }
            }


        }
    }
}