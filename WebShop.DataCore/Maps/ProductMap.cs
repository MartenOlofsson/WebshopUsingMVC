using FluentNHibernate.Mapping;
using WebShop.DataCore.Models;

namespace WebShop.DataCore.Maps
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name).Length(100).Not.Nullable();
            Map(x => x.Pris);
            Map(x => x.NumberInStock);
            Map(x => x.Brand);
            References(x => x.SubCat);
            Map(x => x.Picture);
        }

    }
}
