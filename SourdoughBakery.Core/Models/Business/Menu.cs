using System;
using System.Collections.Generic;
using System.Text;

namespace SourdoughBakery.Core.Models.Business
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
