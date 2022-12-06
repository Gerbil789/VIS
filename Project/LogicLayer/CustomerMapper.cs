using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLayer.DataStructures;

namespace LogicLayer
{
    public static class CustomerMapper
    {
        public static Dictionary<int, Customer> pool = new Dictionary<int, Customer>();

        public static void AddCustomer(Customer customer)
        {
            int id = customer.id;
            if (!pool.ContainsKey(id))
            {
                pool.Add(id, customer);
                return;
            }

            pool[id] = customer;
        }



        public static bool RemoveCustomer(int id)
        {
            if (!pool.ContainsKey(id))
                return false;

            return pool.Remove(id);
        }

        public static List<Customer> GetCustomers(string name)
        {
            List<Customer> customers = DataGateway.GetCustomers(name);
            foreach (Customer customer in customers)
            {
                if (!pool.ContainsKey(customer.id))
                    AddCustomer(customer);
            }
            return customers;
        }

        public static Customer GetCustomer(int id)
        {
            if (!pool.ContainsKey(id)){ 
                Customer? customer = DataGateway.GetCustomer(id);
                AddCustomer(customer);
            }
              
            return pool[id];
        }
    }
}
