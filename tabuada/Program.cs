using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo a TABUADA---");

            bool continua = true;

            int dec = 1;

            do
            {

                Console.Write("Digite o numero que deseja saber a tabuada:");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero}X{i} = {i * numero}");
                }

                do
                {
                    Console.WriteLine("Deseja efetuar outra tabuada? (1)-sim (2)-não");
                    dec = int.Parse(Console.ReadLine());

                    if (dec == 1)
                        continua = true;
                    else if (dec == 2)
                        continua = false;

                } while (dec != 1 && dec != 2);


            } while (continua);

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();

        }
    }
}
