using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital_Management_System.Mappers
{
    internal class AccountantMap : ClassMap<Accountant>
    {
        public AccountantMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);

        }
    }
}
