using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_pedido_4lions.Entidades {
    internal class Cliente : Endereco {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Cliente
            (int id, string nome, int idade, string logradouro, string logradouro1, int numero, string municipio, string uf) : base (logradouro, logradouro1, numero, municipio, uf) {
            Id = id;
            Nome = nome;
            Idade = idade;
        }
    }
}
