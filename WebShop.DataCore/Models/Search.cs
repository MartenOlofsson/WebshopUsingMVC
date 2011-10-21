using System;

namespace WebShop.DataCore.Models
{
    public class Search
    {

        public virtual int Id { get; set; }
        public virtual string SearchString { get; set; }
        public virtual Guid GuidId { get; set; }
        public virtual DateTime Time { get; set; }

    }
}
