using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using WebShop.DataCore.Models;

namespace WebShop.DataCore.Maps
{
    public class ProductsOnCampaignMap : ClassMap<ProductsOnCampaign>
    {
        public ProductsOnCampaignMap()
        {
            Id(x => x.Id);
            References(x => x.Product);
            Map(x => x.StartTime);

            Map(x => x.CampaginPrice);

        }
    }
}
