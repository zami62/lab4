using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace lab4
{
    public class CustomersTableAdapter
    {
        ApplicationContext db = new ApplicationContext();

        public void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
        }

        public int GetLastID()
        {
            int? id = db.Parts.Max(mb => mb.ID);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<Customer>? GetCustomers()
        {
            List<Customer>? customers = db.Customers.ToList();
            return customers;
        }

        public Customer? GetCustomerByID(int customerID)
        {
            Customer? customer = (from p in db.Customers where p.ID == customerID select p).First();
            return customer; 
        }

        public List<Customer>? GetCustomersByName(string name)
        {
            List<Customer>? customers = (from c in db.Customers where c.Name.Contains(name) select c).ToList();
            return customers;
        }

        public List<Customer>? GetCustomersByPhoneNumber(string phoneNumber)
        {
            List<Customer>? customers = (from c in db.Customers where c.PhoneNumber.Contains(phoneNumber) select c).ToList();
            return customers;
        }

        public void UpdateCustomerName(int customerID, string newName)
        {
            Customer? customer = (from c in db.Customers where c.ID == customerID select c).First();
            if (customer != null)
            {
                customer.Name = newName;
                db.SaveChanges();
            }
        }

        public void UpdateCustomerPhoneNumber(int customerID, string newPhoneNumber)
        {
            Customer? customer = (from p in db.Customers where p.ID == customerID select p).First();
            if (customer != null)
            {
                customer.PhoneNumber = newPhoneNumber;
                db.SaveChanges();
            }
        }

        public void RemoveCustomer(int customerID)
        {
            Customer? customer = (from p in db.Customers where p.ID == customerID select p).First();
            if (customer != null)
            {
                db.Customers.Remove(customer);
            }
        }
    }
}
