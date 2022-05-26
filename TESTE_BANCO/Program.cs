using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_BANCO;

namespace TESTE_BANCO
{
    class Program
    {
        static List<IConta> ContasBancarias = new List<IConta>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ContasBancarias.Add(new ContaPoupanca(10, "Correntista", 10));
            }
            Saques();
            Depositos();
            Console.ReadKey();
        }
        private static void Saques()
        {
            ContasBancarias.ForEach(e => e.Debitar(200));
        }
        private static void Depositos()
        {
            ContasBancarias.ForEach(e => e.Creditar(100));
        }
    }
}
