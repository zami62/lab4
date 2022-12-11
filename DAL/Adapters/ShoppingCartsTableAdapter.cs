using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace lab4
{
    public class ShoppingCartsTableAdapter
    {
        ApplicationContext db = new ApplicationContext();

        public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            db.ShoppingCarts.Add(shoppingCart);
        }

        public int GetLastID()
        {
            int? id = db.Parts.Max(mb => mb.ID);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<ShoppingCart>? GetShoppingCarts()
        {
            List<ShoppingCart>? shoppingCarts = db.ShoppingCarts.ToList();
            return shoppingCarts;
        }

        public List<ShoppingCart>? GetSCByOrderID(int orderID)
        {
            List<ShoppingCart>? shoppingCarts = (from sc in db.ShoppingCarts where sc.OrderID == orderID select sc).ToList();
            return shoppingCarts;
        }

        public ShoppingCart? GetSCByOrderAndPartIDs(int orderID, int partID)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where ((sc.OrderID == orderID) && (sc.PartID == partID)) select sc).FirstOrDefault();
            return shoppingCart;
        }

        public ShoppingCart? GetShoppingCart(int cartID)
        {
            ShoppingCart? shoppingCarts = (from sc in db.ShoppingCarts where sc.ID == cartID select sc).FirstOrDefault();
            return shoppingCarts;
        }

        // UPDATING BY ORDER ID AND PART ID

        public void UpdateSCPartByOrderID(int orderID, int partID, int newPartID)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where ((sc.OrderID == orderID) && (sc.PartID == partID)) select sc).FirstOrDefault();
            if (shoppingCart != null)
            {
                shoppingCart.PartID = newPartID;
                db.SaveChanges();
            }
        }

        public void UpdateSCPartCountByOrderID(int orderID, int partID, int newCount)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where ((sc.OrderID == orderID) && (sc.PartID == partID)) select sc).First();
            if (shoppingCart != null)
            {
                shoppingCart.Count = newCount;
                db.SaveChanges();
            }
        }

        public void UpdateSCPriceByOrderID(int orderID, int partID, float newPrice)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where ((sc.OrderID == orderID) && (sc.PartID == partID)) select sc).First();
            if (shoppingCart != null)
            {
                shoppingCart.Price = newPrice;
                db.SaveChanges();
            }
        }

        // UPDATING BY SHOPPING CART ID

        public void UpdateSCOrderID(int cartID, int newOrderID)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where sc.ID == cartID select sc).First();
            if (shoppingCart != null)
            {
                shoppingCart.OrderID = newOrderID;
                db.SaveChanges();
            }
        }

        public void UpdateSCPart(int cartID, int newPartID)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where sc.ID == cartID select sc).First();
            if (shoppingCart != null)
            {
                shoppingCart.PartID = newPartID;
                db.SaveChanges();
            }
        }

        public void UpdateSCPartCount(int cartID, int newCount)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where sc.ID == cartID select sc).First();
            if (shoppingCart != null)
            {
                shoppingCart.Count = newCount;
                db.SaveChanges();
            }
        }

        public void UpdateSCPrice(int cartID, float newPrice)
        {
            ShoppingCart? shoppingCart = (from sc in db.ShoppingCarts where sc.ID == cartID select sc).First();
            if (shoppingCart != null)
            {
                shoppingCart.Price = newPrice;
                db.SaveChanges();
            }
        }

        public void RemoveShoppingCart(int cartID)
        {
            ShoppingCart? shoppingCart = (from p in db.ShoppingCarts where p.ID == cartID select p).First();
            if (shoppingCart != null)
            {
                db.ShoppingCarts.Remove(shoppingCart);
            }
        }
    }
}
