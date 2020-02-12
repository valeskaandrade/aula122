using System;
using System.Collections.Generic;
using System.Text;

namespace TesteEnumEComposicao.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Prossessing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
