using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bom dia, " + nome + " você tem " + idade + " anos.");

            Console.ReadKey();
        }
    }
}
