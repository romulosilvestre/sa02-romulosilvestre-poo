using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a qtde aviões!");
            var qtde = int.Parse(Console.ReadLine());
            Aplicativo3RN rn3 = new Aplicativo3RN();
            Console.WriteLine($"Total Geral de Assentos:{rn3.CalcularTotalAssentos(qtde)}");
            Console.ReadKey();
        }
    }
}
