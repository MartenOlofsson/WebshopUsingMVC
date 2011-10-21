using System;
using System.Web;

namespace WebShop.DataCore.Models
{
    public class CookieHandler
    {
    
        
        public static Guid GetUserId()
        {

            if (HttpContext.Current.Request.Cookies["ShoppingCartCookie"] != null)
                return new Guid(HttpContext.Current.Request.Cookies["ShoppingCartCookie"].Value);

            var guid = Guid.NewGuid();
            var cookie = new HttpCookie("ShoppingCartCookie");
            cookie.Value = guid.ToString();
            cookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(cookie);

            return guid;

        }
    }
}
