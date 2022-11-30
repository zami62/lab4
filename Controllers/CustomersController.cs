using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using lab4;

namespace lab4.Controllers
{
    [ApiController]
    [Route("/controller")]
    [ApiExplorerSettings(GroupName = "customers")]
    public class CustomersController : ControllerBase
    {

        CustomersBLL BLL = new CustomersBLL();

        [HttpPut]
        [Route("/add")]
        public void AddCustomer(string name, string phoneNumber)
        {
            BLL.AddCustomer(name, phoneNumber);
        }

        [HttpGet]
        [Route("/get all")]
        public List<Customer> GetCustomers()
        {
            return BLL.GetCustomers();
        }

        [HttpGet]
        [Route("/get by id")]
        public Customer GetCustomerByID(int partID)
        {
            return BLL.GetCustomerByID(partID);
        }

        [HttpGet]
        [Route("/get by name")]
        public List<Customer> GetCustomersByName(string name)
        {
            return BLL.GetCustomersByName(name);
        }

        [HttpGet]
        [Route("/get by phone number")]
        public List<Customer> GetCustomersByPhoneNumber(string phoneNumber)
        {
            return BLL.GetCustomersByName(phoneNumber);
        }

        [HttpPatch]
        [Route("/patch name")]
        public void UpdateCustomerName(int partID, string newName)
        {
            BLL.UpdateCustomerName(partID, newName);
        }

        [HttpPatch]
        [Route("/patch phone number")]
        public void UpdateCustomerPhoneNumber(int partID, string newPhoneNumber)
        {
            BLL.UpdateCustomerName(partID, newPhoneNumber);
        }

        [HttpDelete]
        [Route("/delete by id")]
        public void RemoveCustomer(int partID)
        {
            BLL.RemoveCustomer(partID);
        }

    }
}
