using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    [System.ComponentModel.DataObject]
    public class CustomersBLL
    {
        private CustomersTableAdapter Adapter = new CustomersTableAdapter();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddCustomer(string name, string phoneNumber)
        {
            Adapter.AddCustomer(new Customer { 
                ID = Adapter.GetLastID() + 1, 
                Name = name, 
                PhoneNumber = phoneNumber });
        }

        public List<Customer> GetCustomers()
        {
            return Adapter.GetCustomers();
        }

        public Customer GetCustomerByID(int customerID)
        {
            return Adapter.GetCustomerByID(customerID);
        }

        public List<Customer> GetCustomersByName(string name)
        {
            return Adapter.GetCustomersByName(name);
        }

        public List<Customer> GetCustomersByPhoneNumber(string phoneNumber)
        {
            return Adapter.GetCustomersByName(phoneNumber);
        }

        public void UpdateCustomerName(int customerID, string newName)
        {
            Adapter.UpdateCustomerName(customerID, newName);
        }

        public void UpdateCustomerPhoneNumber(int customerID, string newPhoneNumber)
        {
            Adapter.UpdateCustomerName(customerID, newPhoneNumber);
        }

        public void RemoveCustomer(int customerID)
        {
            Adapter.RemoveCustomer(customerID);
        }
    }
}
