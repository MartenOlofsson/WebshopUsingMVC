using FluentNHibernate.Mapping;
using WebShop.DataCore.Models;

namespace WebShop.DataCore.Maps
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name).Length(100).Not.Nullable();
            Map(x => x.CategoryPicture);
            Map(x => x.Class);
            HasMany(x => x.ListOfSubCategories);
        }
    }
}
