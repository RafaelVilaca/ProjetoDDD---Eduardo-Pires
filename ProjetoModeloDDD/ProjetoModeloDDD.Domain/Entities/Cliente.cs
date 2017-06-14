using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }

        public int IsValid()
        {
            string email = this.Email;
            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))
                                    (?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            if (!rg.IsMatch(email) || string.IsNullOrEmpty(email))
                return 1;

            if (string.IsNullOrEmpty(Sobrenome) || this.Sobrenome.Trim().Length < 3)
                return 2;

            if (string.IsNullOrEmpty(Nome) || this.Nome.Trim().Length < 3)
                return 3;

            return 0;
        }
    }
}
