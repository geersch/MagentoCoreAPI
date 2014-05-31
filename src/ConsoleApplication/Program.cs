using System;
using ConsoleApplication.Version2;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            using (Mage_Api_Model_Server_V2_HandlerPortTypeClient proxy = new Mage_Api_Model_Server_V2_HandlerPortTypeClient())
            {
                string sessionId = proxy.login("your_username", "your_api_key");

                customerCustomerEntity[] customers = proxy.customerCustomerList(sessionId, new filters());

                foreach(customerCustomerEntity customer in customers)
                {
                    Console.WriteLine(String.Format("{0}. {1} {2}", customer.customer_id, customer.firstname, customer.lastname));
                }

                proxy.endSession(sessionId);
            }
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
