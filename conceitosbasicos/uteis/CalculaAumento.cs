using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosbasicos.uteis
{
    public class CalculaAumento
    {
        public static decimal CalculaSalario(decimal salarioAtual, decimal porcentagemDeAumento)
        {
            return salarioAtual + (salarioAtual * (porcentagemDeAumento/100));
        }
    }
}
