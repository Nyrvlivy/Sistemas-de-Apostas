using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_de_Apostas
{
    internal class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine();
         Console.WriteLine("Digite a quantidade de cartões:");
         int c = int.Parse(Console.ReadLine());
         Console.WriteLine("Digite a quantidade de número para cartões:");
         int n = int.Parse(Console.ReadLine());

         Console.WriteLine();
         int[,] m = new int[c, n];
         Random random = new Random();
         for (int i = 0; i < m.Length; i++)
         {
                int sorteado = random.Next(1, 60);
                if (i == 0)
                    m[c, n] = sorteado;
                else
                {
                    if (Array.BinarySearch(m, sorteado) < 0)
                        m[c, n] = sorteado;
                }

                if (i != m.Length - 1)
                    Console.WriteLine(m[c, n] + "-");

                else
                    Console.WriteLine(m[c, n]);
         }
         Console.WriteLine();
         Array.Sort(m);
         for (int i = 0; i < m.Length; i++)
            {
                if (i != m.Length - 1)
                    Console.Write(m[c, n]);
                else
                    Console.Write(m[c, n]);
            }
                    Console.ReadKey();





         }
     }
 }
