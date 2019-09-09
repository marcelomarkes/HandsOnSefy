using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ApoliceCar.Models
{
    public class Apolices
    {
        public int IdApolice { get; set; }
        public int NumeroApolice { get; set; }
        public DateTime DtInicioApolice { get; set; }
        public DateTime DtFimApolice { get; set; }
        public decimal ValorApolice { get; set; }
        public decimal FraqnuiaApolice { get; set; }
        public DateTime DtContratoApolice { get; set; }
    }
}
