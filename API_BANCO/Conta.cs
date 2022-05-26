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
    }
}
