using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Data.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string ThumNailImageURL { get; set; }
        public int StockCount { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
