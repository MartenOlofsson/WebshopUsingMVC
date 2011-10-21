using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace WebShop.DataCore.Models
{
    public class CartEventsProducer
    {
        private ISession session;
        public CartEventsProducer(ISession session)
        {
            this.session = session;
        }

        public IList<CartUpdateEvents> GetEventsFromDb(Guid shoppingCartId)
        {

            var events = (from evnt in session.QueryOver<CartUpdateEvents>()
                          where evnt.Guid == shoppingCartId
                          select evnt).List();

            return events;

        }

        public  void CartPutEventsInDb(Guid guid, int productId)
        {

            var badAssEvent = new CartUpdateEvents();
            
            badAssEvent.DateTime = DateTime.Now;
            badAssEvent.Guid = guid;
            var productEvents = session.Get<Product>(productId);
            badAssEvent.Change = 1;
            badAssEvent.Product = productEvents;
            session.Save(badAssEvent);
            session.Flush();

            session.Dispose();

        }
        public  void RemoveOneItemFromStock(Guid guid, int productId)
        {
           
            var badAssEvent = new CartUpdateEvents();
            badAssEvent.DateTime = DateTime.Now;
            badAssEvent.Guid = guid;
            var productEvents = session.Get<Product>(productId);
            badAssEvent.Product = productEvents;
            badAssEvent.Change = -1;
            session.Save(badAssEvent);

            session.Flush();
          
            session.Dispose();


        }

        public  void RemoveRowFromCart(Guid guid, int productId, int amount)
        {
           
            var badAssEvent = new CartUpdateEvents();
            badAssEvent.DateTime = DateTime.Now;
            badAssEvent.Guid = guid;

            var productEvents = session.Get<Product>(productId);
            badAssEvent.Product = productEvents;
            badAssEvent.Change = -amount;
            session.Save(badAssEvent);
            session.Flush();
         
            session.Dispose();


        }

        public void CartPutManyEventsInDb(Guid guid, int productId, int amount)
        {


            var badAssEvent = new CartUpdateEvents();
            badAssEvent.DateTime = DateTime.Now;
            badAssEvent.Guid = guid;
            var product = session.Get<Product>(productId);
            badAssEvent.Change = amount;
            badAssEvent.Product = product;
            session.Save(badAssEvent);

            session.Flush();

            session.Dispose();

        }

    }
}
