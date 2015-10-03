using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  RFB.BusinessModel;

namespace RFB.ServiceInterface
{
   public class IOrdersService
    {
       Orders GetOrdersByCustomerId();
       Orders GetOrderByMerchantId();
    }
}
