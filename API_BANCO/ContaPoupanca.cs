using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BANCO
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(long Numero, string Correntista, double Saldo) : base (Numero, Correntista, Saldo)
        {

        }
        public override void Debitar(double valor)
        {
            if(valor > this.Saldo) {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine("CREDITO: {0:C2}", valor);
                Console.WriteLine("SALDO: {0:C2}", this.Saldo);
            }
        }
    }
}
