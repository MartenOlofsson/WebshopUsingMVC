using FluentNHibernate.Mapping;
using WebShop.DataCore.Models;

namespace WebShop.DataCore.Maps
{
    public class SearchMap : ClassMap<Search>
    {
        public SearchMap()
        {
            Id(x => x.Id);
            Map(x => x.SearchString);
            Map(x =>x.GuidId);
            Map(x => x.Time);
        }
    }
}
