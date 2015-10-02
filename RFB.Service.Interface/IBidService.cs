using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.BusinessObjects;

namespace RFB.ServiceInterface
{
   public interface IBidService
    {
        void SaveMerchantBid(Bid _bid);
        void SaveRFB(RFB.BusinessObjects.RFB _rfb);
    }
}
