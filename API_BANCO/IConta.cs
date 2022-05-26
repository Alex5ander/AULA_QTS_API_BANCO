using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BANCO
{
    public interface IConta
    {
        void Creditar(double saldo);
        void Debitar(double saldo);
        void Imprimir();
    }
}
