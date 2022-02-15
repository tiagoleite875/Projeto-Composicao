using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Composicao2.Entites {
    internal class Item {

        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public Item() {
        }

        public Item(int quantidade, double preco, Produto produto) {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal() {
            return Preco * Quantidade;
        }
        public override string ToString() {
            return Produto.Nome
                + ", $"
                + Preco
                + " Quantidade: "
                + Quantidade
                + ", $"
                + SubTotal().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
