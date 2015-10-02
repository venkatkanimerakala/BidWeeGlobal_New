using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.BusinessObjects;

namespace RFB.ServiceInterface
{
   public interface IMerchantService
    {
        string RegiserMerchantInfoReturnOTP(Merchant _merchant);
        bool ValidateMerchantOTP(int _merchantId, string _otp);
        bool AuthenticateMerchant(string _userId, string _password);  
        List<Notifications> GetAllNotificationsForMerchant(int _merchantId);
        List<Orders> GetAllOrdersForMerchant(int _merchantId);  
    }
}
