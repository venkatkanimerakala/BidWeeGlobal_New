using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.ServiceInterface;
using RFB.BusinessObjects;

namespace RFB.Service
{
   public class ConsumerService : IConsumerService
    {
       
            //**List<Notifications> GetAllNotificationsForConsumer(int _consumerId);
            //**List<Orders> GetAllOrdersForConsumer(int _consumerId);
            //**
           

               //Register Consumer Information and return OTP
               public string RegiserCustomerInfoReturnOTP(Consumer _consumer)
               {
                   //Build a common library to access azure library for Merchant and Consumer to access OTP
                   return "otp password goes here";
               }

               //Validate the customer OTP with the one stored on the server for this Consumer Id
               public bool ValidateConsumerOTP(int _consumerId, string _otp)
               {
                   return true;
               }

               //Use either oAuth or straight validation against DB
                public bool AuthenticateConsumer(string _userId, string _password)
               {
                   return true;
               }
        
                //Can be an asynchronous call. Make sure while 
                //Client device registration
                public void RegisterConsumerDevice(Device _devide)
                {

                    //Need to integrate with Notification Hub of Azure....Very Important
                }

                // Return the list of last 20 days notifications for the Customer
                public List<Notifications> GetAllNotificationsForConsumer (int _consumerId)
                {
                    return null;
                }

                //Returns the list of orders from the Customer for the last 30 days

                public List<Orders> GetAllOrdersForConsumer(int _consumerId)
                {
                    return null;
                }


              


        }
}
