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
    [Route("customers")]
    [ApiExplorerSettings(GroupName = "customers")]
    public class CustomersController : ControllerBase
    {

        CustomersBLL BLL = new CustomersBLL();

        [HttpPut]
        [Route("add")]
        public void AddCustomer(string name, string phoneNumber)
        {
            BLL.AddCustomer(name, phoneNumber);
        }

        [HttpGet]
        [Route("get_all")]
        public List<Customer> GetCustomers()
        {
            return BLL.GetCustomers();
        }

        [HttpGet]
        [Route("get_by_id")]
        public Customer GetCustomerByID(int customerID)
        {
            return BLL.GetCustomerByID(customerID);
        }

        [HttpGet]
        [Route("get_by_name")]
        public List<Customer> GetCustomersByName(string name)
        {
            return BLL.GetCustomersByName(name);
        }

        [HttpGet]
        [Route("get_by_phone_number")]
        public List<Customer> GetCustomersByPhoneNumber(string phoneNumber)
        {
            return BLL.GetCustomersByName(phoneNumber);
        }

        [HttpPatch]
        [Route("patch_name")]
        public void UpdateCustomerName(int partID, string newName)
        {
            BLL.UpdateCustomerName(partID, newName);
        }

        [HttpPatch]
        [Route("patch_phone_number")]
        public void UpdateCustomerPhoneNumber(int partID, string newPhoneNumber)
        {
            BLL.UpdateCustomerName(partID, newPhoneNumber);
        }

        [HttpDelete]
        [Route("/delete_by_id")]
        public void RemoveCustomer(int partID)
        {
            BLL.RemoveCustomer(partID);
        }

    }
}
