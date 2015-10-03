using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.BusinessModel;

namespace RFB.APIService
{
   public class OrderServices
    {
       public Orders GetOrdersByCustomerId()
       {
           Orders objOrder = new Orders { _currencyId = 1, _customerId=2, _deliveryDate= DateTime.Now,_isDelivered = true,_isSuccessful=true,_orderDate=DateTime.Now,_orderId=1,_orderUniqueId=1,_productId=3,_purchasePrice=29,_quantity=30,_rfbID=1,_sellerId=1};

           return objOrder;
       }
       public Orders GetOrderByMerchantId()
       {
           return null;
       }
    }
}
