using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            UInt16 idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Informe seu gênero. Pressione F para feminino e M para masculino. ");
            string genero = Console.ReadKey(true).KeyChar.ToString();

            // faz o programa pular a linha
            Console.WriteLine("\r\n");


            Console.WriteLine("Olá " + nome + " !");
            Console.WriteLine("Você tem " +  idade + " anos de idade");
            switch (genero)
            {
                case "F":
                    Console.WriteLine("E seu gênero é feminino");
                    break;
                case "M":
                    Console.WriteLine("E seu gênero é masculino");
                    break;
            }

            Console.ReadKey();
        }
    }
}
