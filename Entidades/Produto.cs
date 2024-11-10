using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pedido_4lions.Entidades {
    internal class Produto {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Valor { get; set; }

        public Produto(int id, string descricao, int estoque, double valor) {
            Id = id;
            Descricao = descricao;
            Estoque = estoque;
            Valor = valor;
        }
    }
}
