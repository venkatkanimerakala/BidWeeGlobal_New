using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.BusinessObjects;


namespace RFB.ServiceInterface
{
    public interface IConsumerService
    {
        string RegiserCustomerInfoReturnOTP(Consumer _consumer);
        bool ValidateConsumerOTP(int _consumerId, string _otp);      
        List<Notifications> GetAllNotificationsForConsumer(int _consumerId);
        List<Orders> GetAllOrdersForConsumer(int _consumerId);
        bool AuthenticateConsumer(string _userId, string _password);
        void RegisterConsumerDevice(Device _device);       
             
    }
}
