using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
namespace Entities
{
    enum OrderStatus:int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped= 2,
        Delivered = 3
    }
}