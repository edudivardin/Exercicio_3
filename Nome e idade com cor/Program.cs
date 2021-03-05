using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Processar();

            Console.ReadKey();
        }

        private static void Processar()
        {
            int Idade;
            Console.Write("Informe a sua idade: ");
            int.TryParse(Console.ReadLine(), out Idade);

            if (Idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso permitdo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso Negado");
            }
        }
    }
}