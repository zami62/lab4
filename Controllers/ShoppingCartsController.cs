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
    [ApiExplorerSettings(GroupName = "ShoppingCarts")]
    public class ShoppingCartsController : ControllerBase
    {

        ShoppingCartsBLL BLL = new ShoppingCartsBLL();

        [HttpPut]
        [Route("/add")]
        public void AddShoppingCart(int orderID, int partID, int partCount)
        {
            BLL.AddShoppingCart(orderID, partID, partCount);
        }

        [HttpGet]
        [Route("/get all")]
        public List<ShoppingCart> GetShoppingCarts()
        {
            return BLL.GetShoppingCarts();
        }

        [HttpGet]
        [Route("/get by order and part ids")]
        public ShoppingCart GetSCByOrderAndPartIDs(int orderID, int partID)
        {
            return BLL.GetSCByOrderAndPartIDs(orderID, partID);
        }

        [HttpGet]
        [Route("/get by cart id")]
        public ShoppingCart GetShoppingCart(int cartID)
        {
            return BLL.GetShoppingCart(cartID);
        }

        // UPDATING BY ORDER ID AND PART ID

        [HttpPatch]
        [Route("/patch part by order and part ids")]
        public void UpdateSCPartByOrderID(int orderID, int partID, int newPartID)
        {
            BLL.UpdateSCPartByOrderID(orderID, partID, newPartID);
        }

        [HttpPatch]
        [Route("/patch count by order and part ids")]
        public void UpdateSCPartCountByOrderID(int orderID, int partID, int count)
        {
            BLL.UpdateSCPartCountByOrderID(orderID, partID, count);
        }

        [HttpPatch]
        [Route("/patch price by order and part ids")]
        public void UpdateSCPriceByOrderID(int orderID, int partID, float newPrice)
        {
            BLL.UpdateSCPriceByOrderID(orderID, partID, newPrice);
        }

        // UPDATING BY SHOPPING CART ID

        [HttpPatch]
        [Route("/patch order by cart id")]
        public void UpdateSCOrderID(int cartID, int newOrderID)
        {
            BLL.UpdateSCOrderID(cartID, newOrderID);
        }

        [HttpPatch]
        [Route("/patch price by cart id")]
        public void UpdateSCPart(int cartID, int newPartID)
        {
            BLL.UpdateSCPart(cartID, newPartID);
        }

        [HttpPatch]
        [Route("/patch count by cart id")]
        public void UpdateSCPartCount(int cartID, int newCount)
        {
            BLL.UpdateSCPartCount(cartID, newCount);
        }

        [HttpPatch]
        [Route("/patch price by cart id")]
        public void UpdateSCPrice(int cartID, int partID, int newPrice)
        {
            BLL.UpdateSCPrice(cartID, partID, newPrice);
        }

        [HttpDelete]
        [Route("/delete by id")]
        public void RemoveShoppingCart(int cartID)
        {
            BLL.RemoveShoppingCart(cartID);
        }

    }
}
