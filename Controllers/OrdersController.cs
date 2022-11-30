using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

using lab4;

namespace lab4.Controllers
{
    [ApiController]
    [Route("/controller")]
    [ApiExplorerSettings(GroupName = "orders")]
    public class OrdersController : ControllerBase
    {

        OrdersBLL BLL = new OrdersBLL();

        [HttpPut]
        [Route("/add")]
        public void AddOrder(int orderID, int customerID, string paymentMethod)
        {
            BLL.AddOrder(orderID, customerID, paymentMethod);
        }

        [HttpGet]
        [Route("/get all")]
        public List<Order> GetOrders()
        {
            return BLL.GetOrders();
        }

        [HttpGet]
        [Route("/get by id")]
        public Order GetOrderByID(int orderID)
        {
            return BLL.GetOrderByID(orderID);
        }

        [HttpPatch]
        [Route("/patch customer")]
        public void UpdateOrderCustomer(int orderID, int newCustomerID)
        {
            BLL.UpdateOrderCustomer(orderID, newCustomerID);
        }

        [HttpPatch]
        [Route("/patch payment method")]
        public void UpdateOrderPaymentMethod(int orderID, string newPaymentMethod)
        {
            BLL.UpdateOrderPaymentMethod(orderID, newPaymentMethod);
        }

        [HttpDelete]
        [Route("/delete by id")]
        public void RemoveOrder(int orderID)
        {
            BLL.RemoveOrder(orderID);
        }

    }
}
