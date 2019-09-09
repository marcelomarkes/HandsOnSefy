using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ApoliceCar.Models
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string FonePessoa { get; set; }
        public string EnderecoPessoa { get; set; }
        public string BairroPessoa { get; set; }
        public string CepPessoa { get; set; }
        public string  CpfPessoa { get; set; }
        public string RgPessoa { get; set; }
        public string SexoPessoa { get; set; }
        public DateTime DtNacimentoPessoa { get; set; }
    }
}
