using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIVIT___.Net_com_GitHub_Copilot.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Endereco { get; set; }
        
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos e moro em {Endereco}."); 
        }
    }
}