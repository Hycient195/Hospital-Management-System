using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    class Bill
    {
        public int Id { get; set; }
        public virtual string Item { get; set; }
        public virtual string Description { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public decimal GetTotalPrice()
        {
            return (decimal)this.Quantity * this.UnitPrice;
        }
    }
}
