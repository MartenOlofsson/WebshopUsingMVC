using System;


namespace WebShop.DataCore.Models
{
    public class CartUpdateEvents
    {
        public virtual int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual Guid Guid { get; set; }
        public virtual int Change { get; set; }

    }

}
