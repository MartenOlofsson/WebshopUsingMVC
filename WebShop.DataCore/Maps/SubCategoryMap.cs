using FluentNHibernate.Mapping;
using WebShop.DataCore.Models;

namespace WebShop.DataCore.Maps
{
    public class SubCategoryMap : ClassMap<SubCategory>
    {
        public SubCategoryMap()
       {
            Id(x => x.Id);
            Map(x => x.Name).Length(100);
            HasMany(x => x.ProductList);
        }
    }
}
