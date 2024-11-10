using projeto_pedido_4lions.Entidades;

namespace projeto_pedido_4lions {
    internal class Program {
        static void Main(string[] args) {
            Cliente ClienteD = new Cliente(1, "Douglas", 23, "13 de Maio", 1199, "Pontal", "SP"); // Criando um objeto cliente
            Produto Produto1 = new Produto(10, "Mouse", 10, 300.00); // Produto mouse com 10 unidades no estoque.
            Produto Produto2 = new Produto(20, "Teclado", 10, 200.00); 
            Produto Produto3 = new Produto(30, "Monitor", 10, 100.00);

            PedidoItem Item1 = new PedidoItem(1, Produto1, 1, Produto1.Valor);
            PedidoItem Item2 = new PedidoItem(2, Produto2, 1, Produto2.Valor);
            PedidoItem Item3 = new PedidoItem(3, Produto3, 1, Produto3.Valor);


            PedidoCabecalho PedidoCab = new PedidoCabecalho(100, DateTime.Now, ClienteD, (Produto1.Valor + Produto2.Valor + Produto3.Valor));
            PedidoCab.AddItem(Item1);
            PedidoCab.AddItem(Item2);
            PedidoCab.AddItem(Item3);

            Console.WriteLine(PedidoCab);


        }
    }
}
