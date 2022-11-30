using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    [System.ComponentModel.DataObject]
    public class ShoppingCartsBLL
    {
        private ShoppingCartsTableAdapter Adapter = new ShoppingCartsTableAdapter();
        private PartsTableAdapter PartsAdapter = new PartsTableAdapter();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddShoppingCart(int orderID, int partID, int partCount)
        {
            float partPrice = PartsAdapter.GetPartByID(partID).TotalPrice;

            Adapter.AddShoppingCart(new ShoppingCart { 
                ID = Adapter.GetLastID(),
                Count = partCount,
                Price = partPrice,
                OrderID = orderID,
                PartID = partID});
        }

        public List<ShoppingCart> GetShoppingCarts()
        {
            return Adapter.GetShoppingCarts();
        }

        public ShoppingCart GetSCByOrderAndPartIDs(int orderID, int partID)
        {
            return Adapter.GetSCByOrderAndPartIDs(orderID, partID);
        }

        public ShoppingCart GetShoppingCart(int cartID)
        {
            return Adapter.GetShoppingCart(cartID);
        }

        // UPDATING BY ORDER ID AND PART ID

        public void UpdateSCPartByOrderID(int orderID, int partID, int newPartID)
        {
            Adapter.UpdateSCPartByOrderID(orderID, partID, newPartID);
        }

        public void UpdateSCPartCountByOrderID(int orderID, int partID, int count)
        {
            Adapter.UpdateSCPartCountByOrderID(orderID, partID, count);
        }

        public void UpdateSCPriceByOrderID(int orderID, int partID, float newPrice)
        {
            Adapter.UpdateSCPriceByOrderID(orderID, partID, newPrice);
        }

        // UPDATING BY SHOPPING CART ID

        public void UpdateSCOrderID(int cartID, int newOrderID)
        {
            Adapter.UpdateSCOrderID(cartID, newOrderID);
        }

        public void UpdateSCPart(int cartID, int newPartID)
        {
            int count = Adapter.GetShoppingCart(cartID).Count;
            int partID = Adapter.GetShoppingCart(cartID).PartID;
            float partPrice = PartsAdapter.GetPartByID(partID).TotalPrice;

            Adapter.UpdateSCPart(cartID, newPartID);
            Adapter.UpdateSCPrice(cartID, partPrice * (float)count);
        }

        public void UpdateSCPartCount(int cartID, int newCount)
        {
            int partID = Adapter.GetShoppingCart(cartID).PartID;
            float partPrice = PartsAdapter.GetPartByID(partID).TotalPrice;
          
            Adapter.UpdateSCPartCount(cartID, newCount);
            Adapter.UpdateSCPrice(cartID, partPrice * newCount);
        }

        public void UpdateSCPrice(int cartID, int partID, int newPrice)
        {
            Adapter.UpdateSCPrice(cartID, newPrice);
        }

        public void RemoveShoppingCart(int cartID)
        {
            Adapter.RemoveShoppingCart(cartID);
        }
    }
}
