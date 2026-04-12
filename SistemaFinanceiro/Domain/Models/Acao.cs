using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Acao : AtivoBase
    {
        public string Ticker;
        public decimal ValorInvestido;
        public DateTime DataCompra;


        public override void AtivoBase(string ticker, decimal valor, DateTime data)
        {
            
        }
        

        
    }
}