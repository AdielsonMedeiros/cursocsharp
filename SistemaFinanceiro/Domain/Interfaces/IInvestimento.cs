using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IInvestimento
    {
        decimal CalcularRendimento();



    }
}