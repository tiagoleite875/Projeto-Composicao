using Composicao2.Entites;
using Composicao2.Entites.Enum;
using System;
using System.Globalization;

namespace combinacao2 {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("nome: ");
            string nome = Console.ReadLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            Console.Write("Dta de nascimento(dd/mm/aaaa): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os dados do pedido:");
            Console.Write("Status (Peding_Payment, Processing, Shipped, Delivered): ");
            StatusDoPedido status = Enum.Parse<StatusDoPedido>(Console.ReadLine());
            
            
            Cliente cliente = new Cliente(nome, email, data);                        
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);
            
            Console.Write("Quantos itens para esse pedido?");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("entre com o item #"+i+" :");
                Console.Write("nome do produto: ");
                string nomeprod = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeprod, preco);

                Console.Write("quantidade: ");

                int qtd = int.Parse(Console.ReadLine());

                Item item = new Item(qtd, preco, produto);

                pedido.AddItem(item);

            }
            Console.WriteLine();
            Console.WriteLine("Resumo do pedido: ");
            Console.WriteLine(pedido);


        }
    }
}