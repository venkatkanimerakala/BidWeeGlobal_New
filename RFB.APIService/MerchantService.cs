using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.ServiceInterface;

using RFB.BusinessObjects;

namespace RFB.Service
{
   public class MerchantService : IMerchantService
    {
        
                 // Registration happens here - Takes Merchant Object as input and returns OTP String
                  public string RegiserMerchantInfoReturnOTP(Merchant _merchant)
                   {
                    // Hook in your OTP API here....
                     return "OTP Password";
                   }

                   //Validate the OTP sent to the mobile against the server
                   public bool ValidateMerchantOTP(int _merchantId, string _otp)
                   {
                       return true;
                   }

                   //Authentication of Merchant
                  public bool AuthenticateMerchant(string _userId, string _password)
                  {
                      //Authenticate User either oAuth or direct
                      return true;
                  }

                  // Saves the Bid entered by the Merchant and returns a Bid Reference Number
                  public int SaveMerchantBid(Bid _bid)
                  {
                      return 0;
                  }


                public void RegisterMerchantDevice(Device _devide)
                  {
                   
                    //Need to integrate with Notification Hub of Azure....Very Important
                  }

                 // Return the list of last 20 days notifications for the merchant
                 public List<Notifications> GetAllNotificationsForMerchant(int _merchantId)
                  {
                      return null;
                  }

                   //Returns the list of orders from the merchant for the last 30 days

                 public List<Orders> GetAllOrdersForMerchant(int _merchantId)
                 {
                     return null;
                 }


    }
}
