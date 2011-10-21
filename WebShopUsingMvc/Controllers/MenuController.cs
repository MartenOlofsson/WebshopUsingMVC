using System;
using System.Linq;
using System.Web.Mvc;
using NHibernate.Linq;
using WebShop.DataCore;
using WebShop.DataCore.Models;

namespace WebShopUsingMvc.Controllers
{
    public class MenuController : Controller
    {


        public ActionResult RenderMenu()
        {


            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();
            session.Flush();

            var result = session.Query<Category>().ToList();

            return PartialView(result);

        }


        public ActionResult RenderPageBottom()
        {

            return PartialView();

        }

        public ActionResult RenderOldSearch()
        {

            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();
            session.Flush();

            var searches = session.Query<Search>().OrderByDescending(x => x.Id).Take(3).ToList(); // vill ta de 3 senaste

            return PartialView(searches);

        }

        public ActionResult RenderOrders()
        {

            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();           
            var guid = CookieHandler.GetUserId();
            
           
            var orders = session.Query<Order>().OrderByDescending(x => x.Id).Take(3).ToList(); // vill ta de 3 senaste

            return PartialView(orders);

        }

        public ActionResult RenderCampaign()
        {
            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();
            var guid = CookieHandler.GetUserId();

            Random rnd = new Random();

            

            var campaignProducts = session.Query<ProductsOnCampaign>().ToList().OrderBy(x => rnd.Next()).Take(3).ToList();

             // vill ta de 3 senaste

            return PartialView(campaignProducts);

        }

    }


}
