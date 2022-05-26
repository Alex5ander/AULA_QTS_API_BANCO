using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BANCO
{
    public class ContaCorrente : Conta
    {
        public double Limite { get; set; }
        public ContaCorrente(long Numero, string Correntista, double Saldo, double Limite) : base (Numero, Correntista, Saldo) 
        {
            this.Limite = Limite;
        }

        public override void Debitar(double valor)
        {
            double disponivel = this.Saldo + this.Limite;
            if (valor > disponivel)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine("DEBITO: {0:C2}", valor);
                Console.WriteLine("SALDO: {0:C2}", this.Saldo);
            }
        }
    }
}
