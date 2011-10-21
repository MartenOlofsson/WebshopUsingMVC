using System.Linq;
using System.Web.Mvc;
using NHibernate.Linq;
using WebShop.DataCore.Models;
using NHibernate;


namespace WebShopUsingMvc.Controllers
{
    public class HomeController : Controller
    {
        ISession session;
        OrderCreator creator;
        public HomeController(ISession session, OrderCreator creator)
        {
            this.session = session;
            this.creator = creator;
        }

        public ActionResult Index()
        {
            var result = session.Query<Category>().ToList();
            return View(result);
        }

        public ActionResult ShoppingCart()
        {

            var id = CookieHandler.GetUserId();
            var cartEventsProducer = new CartEventsProducer(session);

            var list = cartEventsProducer.GetEventsFromDb(id);
            var dictionary = Cart.TakeEventsAndDoCalculations(list);
            return View(dictionary);

        }

        public ActionResult Search(string search)
        {

            var id = CookieHandler.GetUserId();
            RenderSearchResultFromInput.PutSearchInDB(id, search);
            var renderSearchResult = new RenderSearchResultFromInput();
            var result = renderSearchResult.RenderResult(search);
            return View(result);

        }

        public ActionResult AddCategories()
        {
            var filler = new FillDatabase(session);

            var test = filler.FillIt();
            return View(test);
        }

        public ActionResult ListAllProduct()
        {
   
            var result = session.Query<Category>().ToList();
            return View(result);

        }




        public ActionResult AddProductToCartFromSearch(int productId)
        {

            var guid = CookieHandler.GetUserId();
            var eventproducer = new CartEventsProducer(session);

            eventproducer.CartPutEventsInDb(guid, productId);

            return RedirectToAction("ShoppingCart");
        }

        public ActionResult RemoveProductFromCart(int Id)
        {

            var guid = CookieHandler.GetUserId();
            var eventproducer = new CartEventsProducer(session);

            eventproducer.RemoveOneItemFromStock(guid, Id);
            return RedirectToAction("ShoppingCart");
        }

        public ActionResult RemoveRowFromCart(int productId, int amount)
        {
            var guid = CookieHandler.GetUserId();
            var eventproducer = new CartEventsProducer(session);

            eventproducer.RemoveRowFromCart(guid, productId, amount);

            return RedirectToAction("ShoppingCart");
        }

        public ActionResult SortProductsViaFilter()
        {

            return RedirectToAction("ShoppingCart");
        }


        public ActionResult AddProductToCart(int productId)
        {

            var guid = CookieHandler.GetUserId();
            var eventproducer = new CartEventsProducer(session);

            eventproducer.CartPutEventsInDb(guid, productId);

            return RedirectToAction("ListAllProduct");
        }


        
        public ActionResult MakePurchase()
        {
            if (!Request.IsAuthenticated)
                return View();
            
            var sender = new MailSender();
            sender.SendMail();
            
            var guid = CookieHandler.GetUserId();
            var creator = new OrderCreator(session);
            var order = creator.CreateOrder();

           
            session.Delete("from CartUpdateEvents where Guid ='" + guid + "'");
            session.Flush();

            return View();




        }
        public ActionResult Compare(int[] Compare)
        {

            //göra linqfråga här eller i classen
            if (Compare == null)
                return RedirectToAction("Index");
            var compare = new Compare();
            var list = compare.GetCompareProductList(Compare);

            return View(list);

        }

        public ActionResult SubCategoryView(int Id)
        {
            
            
            var result = session.Query<Category>().ToList();
            var category = result[Id-1];
            return View(category);

            
        }

        public ActionResult ProductInfoView(int productId)
        {

            

            var result = session.Query<Product>().ToList();
            var product = result[productId - 1];
            return View(product);


        }


        public ActionResult AddManyProductsToCart(int id, int amount )
        {


            var guid = CookieHandler.GetUserId();

            var eventProducer = new CartEventsProducer(session);

            eventProducer.CartPutManyEventsInDb(guid, id, amount);

            

            return RedirectToAction("ShoppingCart");


        }
    }


}
