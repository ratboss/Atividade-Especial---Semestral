using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] perguntas = new string[5]; //Vetor de perguntas
            int r = 0;//right
            int w = 0;//wrong
            int op;
            int resposta;

            //Perguntas 

            perguntas[0] = "Qual o bloco de código que pode ser chamado a qualquer momento? ";
            perguntas[1] = "Oque é uma variável? ";
            perguntas[2] = "Qual é a estrutura de repetição que se o usuário não faz tal ação o progama continua repetindo a pergunta";
            perguntas[3] = "Qual a estrutura de decisão que constitui de se e senão? ";
            perguntas[4] = "Quais são os tipos de variáveis? ";


            //Menu
            //Gabarito = 1,3,2,4,2

            Console.WriteLine("Deseja começar o quiz?");
            Console.WriteLine("1 - Iniciar quiz");
            Console.WriteLine("2 - Sair do programa");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine(perguntas[0]);
                    Console.WriteLine("1 - Função");
                    Console.WriteLine("2 - For");
                    Console.WriteLine("3 - While");
                    Console.WriteLine("4 - Do While");
                    resposta = Convert.ToInt16(Console.ReadLine());

                    if (resposta == 1)
                    {
                        r++;
                    }
                    else
                    {
                        w++;
                    }

                    
                    Console.Clear();

                    Console.WriteLine(perguntas[1]);
                    Console.WriteLine("1 - Símbolo que representa um número arbitrário, não totalmente especificado ou desconhecido");
                    Console.WriteLine("2 - Definir um ou mais valores que não podem ser manipulados pelo programa durante sua operação");
                    Console.WriteLine("3 - Definir um ou mais valores que são manipulados pelos programas durante a sua operação");
                    Console.WriteLine("4 - Fechar o console");
                    resposta = Convert.ToInt16(Console.ReadLine());

                    if(resposta == 3)
                    {
                        r++;
                    }
                    else
                    {
                        w++;
                    }

                    Console.Clear();

                    Console.WriteLine(perguntas[2]);
                    Console.WriteLine("1 - While");
                    Console.WriteLine("2 - Do While");
                    Console.WriteLine("3 - If");
                    Console.WriteLine("4 - For");
                    resposta = Convert.ToInt16(Console.ReadLine());

                    if(resposta == 2)
                    {
                        r++;
                    }
                    else
                    {
                        w++;
                    }

                    Console.Clear();

                    Console.WriteLine(perguntas[3]);
                    Console.WriteLine("1 - For");
                    Console.WriteLine("2 - Do While");
                    Console.WriteLine("3 - While");
                    Console.WriteLine("4 - If");
                    resposta = Convert.ToInt16(Console.ReadLine());

                    if (resposta == 4)
                    {
                        r++;
                    }
                    else
                    {
                        w++;
                    }

                    Console.Clear();

                    Console.WriteLine(perguntas[4]);
                    Console.WriteLine("1 - Float, Double, Int, String, Parse");
                    Console.WriteLine("2 - Float, Double, Int, String");
                    Console.WriteLine("3 - Double, Int, Float, Int64");
                    Console.WriteLine("4 - Parse, Float, Double, Int, String");
                    resposta= Convert.ToInt16(Console.ReadLine());

                    if(resposta == 2)
                    {
                        r++;
                    }
                    else
                    {
                        w++;
                    }

                    Console.Clear();

                    Console.WriteLine("Você acertou: " + r + " perguntas e errou: " + w + " perguntas.");
                    Sair();




                    break;

                case 2:
                    break;
            }

            do
            {
            } while (op !=2);
            Sair();

            

            
           
        }
        private static void Sair()
        {
            Console.WriteLine("Aperte qualquer botão para sair...");
            Console.ReadKey();
            Environment.Exit(1);
        }

    }
}
