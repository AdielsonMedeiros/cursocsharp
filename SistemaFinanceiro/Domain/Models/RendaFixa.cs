using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class RendaFixa : AtivoBase
    {
        public decimal TaxaAnual;


        public override decimal CalcularRendimento()
        {
            return 0;
        }
        
    }
}