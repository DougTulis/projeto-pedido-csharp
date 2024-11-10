using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pedido_4lions.Entidades {
    internal class Cliente {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(int id, string nome, int idade) {
            Id = id;
            Nome = nome;
            Idade = idade;
        }
    }
}
