using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_de_Apostas
{
    struct numeros
    {
        public int numEscolhidos;
        public numeros(int numEscolhidos) 
        { 
            this.numEscolhidos = numEscolhidos;        
        }
    }
    public class Apostas

    {
        static List<numeros> listaNumeros = new List<numeros>();

        public static int Loteria, Cartao, x90, x60, x30, x15;

        public void Gerador(int tipoLoteria, int quantCartao) 
        {
        Random rand = new Random();

        switch (tipoLoteria)
        {
            case 90:
                Console.WriteLine(rand.Next(1,90));
                    break;

            case 60:
                Console.WriteLine(rand.Next(1,60));
                    break;

            case 30:
                Console.WriteLine(rand.Next(1,30));
                    break;

            case 15:
                 Console.WriteLine(rand.Next(1,15));
                    break;
            }
        }

    static void Main(string[] args)
        {
            Apostas apostas = new Apostas();



            Console.WriteLine($"\n>>>>>>>>LOTERIA ENCANTADA<<<<<<<<<" +
                              $"\nTeste a sua sorte! E tenha a chance de levar até 1 MILHÃO de reais (tirando os impostos, 100 mil) em dinheiro puramente sujo!!!" +
                              $"\nNão perca sua chance de OURO de gastar dinheiro CONOSCO!");

            Console.Write($"\nDeseja adquirir quantos cartões? ");
            int cartao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (true)
            {
                Console.Write("\nQual Loteria deseja comprar? 90, 60, 30 ou 15? (Recomendamos 60 números): ");
                Loteria = int.Parse(Console.ReadLine());
                if ((Loteria == 90) || (Loteria == 60) || (Loteria == 30) || (Loteria == 15)) // 90 até 50; 60 até 20; 30 até 14/ 15 até 7
                {
                    switch (Loteria)
                    {
                        case 90:
                            while (true)
                            {
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 20 e 50!): ");
                                int x90 = int.Parse(Console.ReadLine());
                                int escolhas;
                                for (int i = 0; i < x90; i++)
                                {
                                    escolhas = int.Parse(Console.ReadLine());
                                    listaNumeros.Add(new numeros(escolhas));
                                }
                                Console.WriteLine();
                                if ((x90 >= 20) && (x90 <= 50))
                                {
                                    apostas.Gerador(x90);
                                    break;
                                }
                                else
                                    Console.Write("Escolha entre a faixa respectiva: ");
                            }
                            break;

                        case 60:
                            while (true)
                            {
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 6 e 20!): ");
                                int x60 = int.Parse(Console.ReadLine());
                                int escolhas;
                                for (int i = 0; i < x60; i++)
                                {
                                    escolhas = int.Parse(Console.ReadLine());
                                    listaNumeros.Add(new numeros(escolhas));
                                }
                                Console.WriteLine();
                                if ((x60 >= 6) && (x60 <= 20))
                                {
                                    apostas.Gerador(x60);
                                    break;
                                }
                                else
                                {
                                    Console.Write("Escolha entre a faixa respectiva: ");
                                }  
                            }
                            break;

                        case 30:
                            while (true)
                            {
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 3 e 14!): ");
                                int x30 = int.Parse(Console.ReadLine());
                                int escolhas;
                                for (int i = 0; i < x30; i++)
                                {
                                    escolhas = int.Parse(Console.ReadLine());
                                    listaNumeros.Add(new numeros(escolhas));
                                }
                                Console.WriteLine();
                                if ((x30 >= 3) && (x30 <= 14))
                                {
                                    apostas.Gerador(x30);
                                    break;
                                }
                                else
                                {
                                    Console.Write("Escolha entre a faixa respectiva: ");
                                }
                            }
                            break;

                        case 15:
                            while (true)
                            {
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 1 e 7!): ");
                                int x15 = int.Parse(Console.ReadLine());
                                int escolhas;
                                for (int i = 0; i < x15; i++)
                                {
                                    escolhas = int.Parse(Console.ReadLine());
                                    listaNumeros.Add(new numeros(escolhas));
                                }
                                Console.WriteLine();
                                if ((x15 >= 1) && (x15 <= 7))
                                {
                                    apostas.Gerador(x15);
                                    break;
                                }
                                else
                                {
                                    Console.Write("Escolha entre a faixa respectiva: ");
                                } 
                            }
                            break;
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Por favor! Escolha uma Loteria válida");
                }


                    Console.ReadKey();
                
            }
        }

        private void Gerador(int x90)
        {
            throw new NotImplementedException();
        }
    }
}