using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager(); //classın referansı (örneği) oluşturulmuş oldu.
            manager.Add();
            manager.Update();
        
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer =  new Customer();
            customer.city = "ankara";
            customer.Id = 1;
            customer.FirstName = "engin";
            customer.LastName = "demiroğ";

            Customer customer2 = new Customer
            {
                Id = 2,
                city = "istanbul",
                FirstName = "derin",
                LastName = "demiroğ"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        
        }

    }

    

    

}
