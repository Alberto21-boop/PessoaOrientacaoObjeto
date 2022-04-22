using System;

namespace PessoaApp21
{
    internal class Pessoa
    {
        public string GetNome { get; set; } = default!;
        public int GetIdade { get; set; }
        public string GetProfissao { get; set; } = default!;

        public string Nome()
        {
            return GetNome;
        }
        public int Idade()
        {
            return GetIdade;
        }
        public string Emprego()
        {
            return GetProfissao;
        }
    }
}