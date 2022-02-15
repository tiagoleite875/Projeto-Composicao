using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao2.Entites.Enum {
    enum StatusDoPedido : int {

        Peding_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
