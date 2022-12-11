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
    [Route("shoppingcarts")]
    [ApiExplorerSettings(GroupName = "shoppingcarts")]
    public class ShoppingCartsController : ControllerBase
    {

        ShoppingCartsBLL BLL = new ShoppingCartsBLL();

        [HttpPut]
        [Route("add")]
        public void AddShoppingCart(int orderID, int partID, int partCount)
        {
            BLL.AddShoppingCart(orderID, partID, partCount);
        }

        [HttpGet]
        [Route("get_all")]
        public List<ShoppingCart> GetShoppingCarts()
        {
            return BLL.GetShoppingCarts();
        }

        [HttpGet]
        [Route("get_by_order_and_part_ids")]
        public ShoppingCart GetSCByOrderAndPartIDs(int orderID, int partID)
        {
            return BLL.GetSCByOrderAndPartIDs(orderID, partID);
        }

        [HttpGet]
        [Route("get_by_cart_id")]
        public ShoppingCart GetShoppingCart(int cartID)
        {
            return BLL.GetShoppingCart(cartID);
        }

        // UPDATING BY ORDER ID AND PART ID

        [HttpPatch]
        [Route("patch_part_by_order_and_part_ids")]
        public void UpdateSCPartByOrderID(int orderID, int partID, int newPartID)
        {
            BLL.UpdateSCPartByOrderID(orderID, partID, newPartID);
        }

        [HttpPatch]
        [Route("patch_count_by_order_and_part_ids")]
        public void UpdateSCPartCountByOrderID(int orderID, int partID, int count)
        {
            BLL.UpdateSCPartCountByOrderID(orderID, partID, count);
        }

        [HttpPatch]
        [Route("patch_price_by_order_and_part_ids")]
        public void UpdateSCPriceByOrderID(int orderID, int partID, float newPrice)
        {
            BLL.UpdateSCPriceByOrderID(orderID, partID, newPrice);
        }

        // UPDATING BY SHOPPING CART ID

        [HttpPatch]
        [Route("patch_order_by_cart_id")]
        public void UpdateSCOrderID(int cartID, int newOrderID)
        {
            BLL.UpdateSCOrderID(cartID, newOrderID);
        }

        [HttpPatch]
        [Route("patch_price_by_cart_id")]
        public void UpdateSCPart(int cartID, int newPartID)
        {
            BLL.UpdateSCPart(cartID, newPartID);
        }

        [HttpPatch]
        [Route("patch_count_by_cart_id")]
        public void UpdateSCPartCount(int cartID, int newCount)
        {
            BLL.UpdateSCPartCount(cartID, newCount);
        }

        [HttpPatch]
        [Route("patch_price_by_cart_id")]
        public void UpdateSCPrice(int cartID, int partID, int newPrice)
        {
            BLL.UpdateSCPrice(cartID, partID, newPrice);
        }

        [HttpDelete]
        [Route("delete_by_id")]
        public void RemoveShoppingCart(int cartID)
        {
            BLL.RemoveShoppingCart(cartID);
        }

    }
}
