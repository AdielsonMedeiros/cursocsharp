using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   
using Domain.Interfaces;
using Domain.Models;

namespace Domain
{
    public class Carteira
    {
        private List<IInvestimento> _ativos = new List<IInvestimento>();
        public List<IInvestimento> Ativos => _ativos;


        public void AdicionarAtivo(IInvestimento ativo)
        {
            
        }

        public decimal CalcularSaldoTotal()
        {
            //i
            return 0;
        }

        public decimal CalcularLucroTotal()
        {
           //i
            return 0;
        }
        
    }
}