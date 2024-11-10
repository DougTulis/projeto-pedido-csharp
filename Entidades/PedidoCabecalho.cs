using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pedido_4lions.Entidades {
    internal class PedidoCabecalho {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente _Cliente { get; set; }
        public double ValorTotal { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        public PedidoCabecalho(int id, DateTime data, Cliente cliente, double valorTotal) {
            Id = id;
            Data = data;
            _Cliente = cliente;
            ValorTotal = valorTotal;
        }
        public void AddItem(PedidoItem Item) {
            Itens.Add(Item);
        }
        public void RemoveItem(PedidoItem Item) {
            Itens.Remove(Item);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do cliente: ");
            sb.AppendLine("Id Cliente: " + _Cliente.Id);
            sb.AppendLine("Nome do cliente: " + _Cliente.Nome);
            sb.AppendLine("Idade do cliente: " + _Cliente.Idade);
            sb.AppendLine("Endereço de entrega: ");
            sb.AppendLine
                (_Cliente.Logradouro + ", " + _Cliente.Numero + ", " + _Cliente.Municipio + ", " + _Cliente.Uf);
            sb.AppendLine("Descrição dos itens comprados: ");
            foreach (PedidoItem P in Itens) {

                sb.AppendLine(P.Sequencia + " - " + P.Produto.Descricao + " - " + P.ValorUnit.ToString("F2",CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Id da compra: " + Id);
            sb.AppendLine("Data da compra: " + Data.ToString("dd/MM/yyyy"));
            sb.AppendLine("Valor total: " + ValorTotal.ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
