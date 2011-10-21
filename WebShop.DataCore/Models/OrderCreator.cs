using System;
using NHibernate;

namespace WebShop.DataCore.Models
{
    public class OrderCreator
    {
        private ISession session; 
        public OrderCreator(ISession session)
        {
            this.session = session;
        }

        public Order CreateOrder()
        {

            var order = new Order();

            string date = DateTime.Now.ToString();
            

            order.OrderTime = date;

            session.Save(order);
            session.Flush();

            return order;
        }

    }
}
