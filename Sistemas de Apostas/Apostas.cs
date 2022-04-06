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

        public static int Loteria, Cartao;

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

            while (true)
            {
                Console.Write("\nQual Loteria deseja comprar? 90, 60, 30 ou 15? (Recomendamos 60 números): ");
                Loteria = int.Parse(Console.ReadLine());
                if ((Loteria == 90) || (Loteria == 60) || (Loteria == 30) || (Loteria == 15)) // 90 até 50 - 30 acertos; 60 até 20 - 15 acertos; 30 até 14 - 12 acertos/ 15 até 7 - 5 acertos
                {
                    switch (Loteria)
                    {
                        case 90:
                            while (true)
                            {
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 30 e 50 números!): ");
                                int cartela90 = int.Parse(Console.ReadLine());
                                if ((cartela90 >= 30) && (cartela90 <= 50))
                                {
                                    Console.Write("\nQuais números deseja apostar? Você pode escolher ", cartela90, " números na faixa de 1 a 90!): ");
                                    int escolhas;
                                    for (int i = 0; i < cartela90; i++)
                                    {
                                        escolhas = int.Parse(Console.ReadLine());
                                        if ((escolhas >= 1) && (escolhas <= 90))
                                        {
                                            listaNumeros.Add(new numeros(escolhas));

                                        }
                                        else
                                        {
                                            Console.Write("Escolha um número entre 1 e 90! ");
                                        }
                                    }

                                    apostas.Gerador(cartela90, cartao);

                                    break;
                                }
                                else
                                {
                                    Console.Write("Escolha entre a faixa respectiva: ");
                                }
                            }
                            break;

                        case 60:
                            while (true)
                            {
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 15 e 20 números!): ");
                                int cartela60 = int.Parse(Console.ReadLine());
                                if ((cartela60 >= 15) && (cartela60 <= 20))
                                {
                                    Console.Write("\nQuais números deseja apostar? Você pode escolher ", cartela60, " números na faixa de 1 a 60!): ");
                                    int escolhas;
                                    for (int i = 0; i < cartela60; i++)
                                    {
                                        escolhas = int.Parse(Console.ReadLine());
                                        if ((escolhas >= 1) && (escolhas <= 60))
                                        {
                                            listaNumeros.Add(new numeros(escolhas));

                                        }
                                        else
                                        {
                                            Console.Write("Escolha um número entre 1 e 60! ");
                                        }
                                    }

                                    apostas.Gerador(cartela60, cartao);

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
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 12 e 14 números!): ");
                                int cartela30 = int.Parse(Console.ReadLine());
                                if ((cartela30 >= 12) && (cartela30 <= 14))
                                {
                                    Console.Write("\nQuais números deseja apostar? Você pode escolher ", cartela30, " números na faixa de 1 a 30!): ");
                                    int escolhas;
                                    for (int i = 0; i < cartela30; i++)
                                    {
                                        escolhas = int.Parse(Console.ReadLine());
                                        if ((escolhas >= 1) && (escolhas <= 30))
                                        {
                                            listaNumeros.Add(new numeros(escolhas));

                                        }
                                        else
                                        {
                                            Console.Write("Escolha um número entre 1 e 30! ");
                                        }
                                    }

                                    apostas.Gerador(cartela30, cartao);

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
                                Console.Write("\nQuantos números deseja apostar? Você pode escolher entre 5 e 7!): ");
                                int cartela15 = int.Parse(Console.ReadLine());
                                if ((cartela15 >= 5) && (cartela15 <= 7))
                                {
                                    Console.Write("\nQuais números deseja apostar? Você pode escolher ", cartela15, " números na faixa de 1 a 15!): ");
                                    int escolhas;
                                    for (int i = 0; i < cartela15; i++)
                                    {
                                        escolhas = int.Parse(Console.ReadLine());
                                        if ((escolhas >= 1) && (escolhas <= 15))
                                        {
                                            listaNumeros.Add(new numeros(escolhas));

                                        }
                                        else
                                        {
                                            Console.Write("Escolha um número entre 1 e 15! ");
                                        }
                                    }

                                    apostas.Gerador(cartela15, cartao);

                                    
                                }
                            }
                    }
                            break;                       
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