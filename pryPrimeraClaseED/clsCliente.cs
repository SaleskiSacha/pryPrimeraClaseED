using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPrimeraClaseED
{
    internal class clsCliente
    {
        public Int32 Codigo;
        public String Nombre ;
        public Decimal Deuda = 0;

        public void Comprar( Decimal Importe) 
        {
            Deuda = Deuda + Importe;
        }
        public void Pagar (Decimal Importe)
        {
            Deuda = Deuda - Importe;
        }
        public void Comprar(Decimal Importe, Decimal Intereses)
        {
            Deuda = Deuda + Importe + Intereses;
        }
    }
}
