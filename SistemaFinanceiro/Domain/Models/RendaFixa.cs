using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Models
{
    public class RendaFixa : AtivoBase
    {

        public decimal TaxaAnual { get; set; }

        public RendaFixa(string nome, decimal valor, DateTime data, decimal taxaAnual) 
            : base(nome, valor, data)
        {
            TaxaAnual = taxaAnual;
        }

        


        public override decimal CalcularRendimento()
        {
            return 0;
        }
        
    }
}