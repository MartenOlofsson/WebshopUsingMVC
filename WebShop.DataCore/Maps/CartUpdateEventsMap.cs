using FluentNHibernate.Mapping;
using WebShop.DataCore.Models;

namespace WebShop.DataCore.Maps
{
    public class CartUpdateEventsMap : ClassMap<CartUpdateEvents>
    {

        public CartUpdateEventsMap()
        {
            Id(x => x.Id);
            References(x => x.Product);
            Map(x =>x.DateTime);
            Map(x => x.Change);
            Map(x =>x.Guid);
        }
    }
}
