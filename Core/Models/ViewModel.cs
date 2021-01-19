using System.Collections.Generic;

namespace FreakyFashion.Data.Models
{
    public class ViewModel
    {
        public IEnumerable<Clothing> Clothing { get; set; }
        public IEnumerable<Category> Category { get; set; }


    }
}
