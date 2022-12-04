using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcion = 0;
            while (opcion != 8)
              
            {
                Console.WriteLine("\n1. Invertir posicion");
                Console.WriteLine("2. saber si esta ordenado de mayor a menor");
                Console.WriteLine("3. orden creciente");
                Console.WriteLine("4. numeros repetidos");
                Console.WriteLine("5. Orden de mayor a menor");
                Console.WriteLine("6. buscar numero en lista de numeros");
                Console.WriteLine("7. promedio");
                Console.WriteLine("8. adios");
                try
                {
                    Console.WriteLine("eliga una opcion");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Invertir();
                            break;
                        case 2:
                            Ordenado();
                            break;
                        case 3:
                            OrdenadoEstricto();
                            break;
                        case 4:
                            Repetidos();
                            break;
                        case 5:
                            Ordenar();
                            break;
                        case 6:
                            Buscar();
                            break;
                        case 7:
                            Promedio();
                            break;
                        case 8:
                            Console.WriteLine("Gracias entrar");
                            break;
                        default:
                            Console.WriteLine("error woooong");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error woooong");
                }
            }
            Console.ReadKey();

            static void Invertir()
            {
                try
                {
                    
                    int[] tama = new int[10];
                    
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.WriteLine("agrega numero");
                        tama[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El orden principal es ");
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.Write(tama[i] + " ");
                    }
                    Console.WriteLine("\nsu inversa es ");
                    for (int i = tama.Length - 1; i >= 0; i--)
                    {
                        Console.Write(tama[i] + " ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error woooong");
                }
            }
            static void Ordenado()
            {
                try
                {
                    int[] tama = new int[10];

                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.WriteLine("agrega numero");
                        tama[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int cont = 0;
                    for (int i = 0; i < tama.Length - 1; i++)
                    {
                        if (tama[i] <= tama[i + 1])
                        {
                            cont++;
                        }
                    }
                    Console.WriteLine("Los numeros ingresada son: ");
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.Write(tama[i] + " ");
                    }
                    if (cont == tama.Length - 1)
                    {
                        Console.WriteLine("\nLa lista esta ordenado de menor a mayor");
                    }
                    else
                    {
                        Console.WriteLine("\nLa lista no esta ordenado de menor a mayor");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error wooooong");
                }
            }
            static void OrdenadoEstricto()
            {
                try
                {
                    int[] tama = new int[10];

                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.WriteLine("agrega numero");
                        tama[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int cont = 0;
                    for (int i = 0; i < tama.Length - 1; i++)
                    {
                        if (tama[i] < tama[i + 1])
                        {
                            cont++;
                        }
                    }
                    Console.WriteLine("Los numeros ingresados son: ");
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.Write(tama[i] + " ");
                    }
                    if (cont == tama.Length - 1)
                    {
                        Console.WriteLine("\nLa lista esta de manera crecienta");
                    }
                    else
                    {
                        Console.WriteLine("\nLa lista no esta ordenada de manera creciente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error woooong");
                }
            }
            static void Repetidos()
            {
                try
                {
                    int[] tama = new int[10];

                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.WriteLine("agrega numero");
                        tama[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int cont = 0;
                    for (int i = 0; i < tama.Length - 1; i++)
                    {
                        for (int j = i + 1; j < tama.Length; j++)
                        {
                            if (tama[i] == tama[j])
                            {
                                cont++;
                            }
                        }
                    }
                    Console.WriteLine("Los numeros ingresada son: ");
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.Write(tama[i] + " ");
                    }
                    if (cont > 0)
                    {
                        Console.WriteLine("\nhay numeros repetidos y son: ");
                        for (int i = 0; i < tama.Length - 1; i++)
                        {
                            for (int j = i + 1; j < tama.Length; j++)
                            {
                                if (tama[i] == tama[j])
                                {
                                    Console.Write(tama[i] + " ");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nno hay numeros repetidos :)");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error woooong");
                }
            }
            static void Ordenar()
            {
                try
                {
                    int[] tama = new int[10];

                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.WriteLine("agrega un numero");
                        tama[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int aux;
                    for (int i = 0; i < tama.Length - 1; i++)
                    {
                        for (int j = i + 1; j < tama.Length; j++)
                        {
                            if (tama[i] > tama[j])
                            {
                                aux = tama[i];
                                tama[i] = tama[j];
                                tama[j] = aux;
                            }
                        }
                    }
                    Console.WriteLine("\nel orden de menor a mayor es: ");
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.Write(tama[i] + " ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error woooooong");
                }
            }
            static void Buscar()
            {
                try
                {
                    int[] tama = new int[10];

                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.WriteLine("agrega un numero");
                        tama[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("numero a buscar");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int cont = 0;
                    for (int i = 0; i < tama.Length; i++)
                    {
                        if (tama[i] == num)
                        {
                            cont++;
                        }
                    }
                    Console.WriteLine("Los numeros ingresados son:");
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.Write(tama[i] + " ");
                    }
                    if (cont > 0)
                    {
                        Console.WriteLine("\nel numero " + num + " esta repetido " + cont + " veces");
                    }
                    else
                    {
                        Console.WriteLine("\nEl numero " + num + " no se encuentra en la lista");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error woooong");
                }
            }
            static void Promedio()
            {
                try
                {
                    int[] tama = new int[10];

                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.WriteLine("agrege un numero");
                        tama[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int suma = 0;
                    for (int i = 0; i < tama.Length; i++)
                    {
                        suma = suma + tama[i];
                    }
                    int promedio = suma / tama.Length;
                    Console.WriteLine("Los numeros ingresados son  ");
                    for (int i = 0; i < tama.Length; i++)
                    {
                        Console.Write(tama[i] + " ");
                    }
                    Console.WriteLine("\nEl promedio es " + promedio);
                }
                catch (Exception)
                {
                    Console.WriteLine("error woooong");
                }
            }
        }
    }
}
