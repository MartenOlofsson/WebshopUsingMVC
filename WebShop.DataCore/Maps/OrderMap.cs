using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using WebShop.DataCore.Models;


namespace WebShop.DataCore.Maps
{
    public class OrderMap : ClassMap<Order>
    {

        public OrderMap()
        {
            Id(x => x.Id);
            Map(x => x.OrderTime);
        }
    }
}
