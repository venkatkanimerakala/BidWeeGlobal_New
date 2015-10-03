using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFB.BusinessModel
{
  public class Orders
    {
      public Int64 _orderId;
      public Int64 _productId;
      public Int64 _quantity;
      public decimal _purchasePrice;
      public DateTime _orderDate;
      public string _orderUniqueId;
      public DateTime _deliveryDate;
      public bool _isSuccessful;
      public bool _isDelivered;
      public Int64 _sellerId;
      public Int64 _customerId;
      public Int64 _currencyId;
      public Int64 _rfbID;

    }
}
