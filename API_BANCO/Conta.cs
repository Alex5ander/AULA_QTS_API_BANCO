using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BANCO
{
    public abstract class Conta
    {
        public long Numero { get; set; }
        public string Correntista { get; set; }
        public double Saldo { get; set; }

        public Conta(long Numero, string Correntista, double Saldo)
        {
            this.Numero = Numero;
            this.Correntista = Correntista;
            this.Saldo = Saldo;
        }
        public void Creditar(double valor)
        {
            this.Saldo += valor;
            Console.WriteLine("CREDITO: {0:C2}", valor);
            Console.WriteLine("SALDO: {0:C2}", this.Saldo);
        }
        public abstract void Debitar(double valor);
    }
}
