using Composicao2.Entites.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Composicao2.Entites {
    class Pedido {

        public DateTime Momento { get; set; }
        public StatusDoPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();

        public Pedido() {
        }

        public Pedido(DateTime momento, StatusDoPedido status, Cliente cliente) {
            Momento = momento;
            Status = status;
            Cliente = cliente;           
        }
        public void AddItem(Item item) {
            Itens.Add(item);
        }
        public void RemoveItem(Item item) {
            Itens.Remove(item);
        }
        public double Total() {
            double sum = 0.00;
            foreach (Item item in Itens) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hora do pedido: " + Momento.ToString("G"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido:");

            foreach( Item item in Itens) {

                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço Total: " + Total().ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();


        }
    }
}
