using System;
using System.Collections.Generic;
using System.Text;

namespace SourdoughBakery.Core.Models.Business
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Available { get; set; }

        public bool IsGlutenFree { get; set; }
    }
}
