using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    [System.ComponentModel.DataObject]
    public class OrdersBLL
    {
        private OrdersTableAdapter Adapter = new OrdersTableAdapter();
        private ShoppingCartsTableAdapter ShoppingCartAdapter = new ShoppingCartsTableAdapter();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddOrder(int orderID, int customerID, string paymentMethod)
        {
            List<ShoppingCart> cartsInOrder = ShoppingCartAdapter.GetSCByOrderID(orderID);

            float cartsTotalPrice = 0;

            foreach(ShoppingCart cart in cartsInOrder)
            {
                cartsTotalPrice += cart.Price;
            }

            Adapter.AddOrder(new Order {
                ID = orderID,
                CustomerID = customerID,
                OrderCreationDate = DateTime.Now,
                Price = cartsTotalPrice,
                PaymentMethod = paymentMethod});;
            
        }

        public List<Order> GetOrders()
        {
            return Adapter.GetOrders();
        }

        public Order GetOrderByID(int orderID)
        {
            return Adapter.GetOrderByID(orderID);
        }

        public void UpdateOrderCustomer(int orderID, int newCustomerID)
        {
            Adapter.UpdateOrderCustomer(orderID, newCustomerID);
        }

        public void UpdateOrderPaymentMethod(int orderID, string newPaymentMethod)
        {
            Adapter.UpdateOrderPaymentMethod(orderID, newPaymentMethod);
        }

        public void RemoveOrder(int orderID)
        {
            Adapter.RemoveOrder(orderID);
        }
    }
}
