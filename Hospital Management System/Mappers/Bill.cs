using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;


namespace Hospital_Management_System.Mappers
{
    internal class BillMap : ClassMap<Bill>
    {
        public BillMap()
        {
            Id(x => x.Id);
            Map(x => x.Item);
            Map(x => x.Description);
            Map(x => x.Quantity);
            Map(x => x.UnitPrice);
        }

    }
}
