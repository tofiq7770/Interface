using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
    }
}
