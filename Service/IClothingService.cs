using System.Collections.Generic;
using FreakyFashion.Data.Models;

namespace FreakyFashion.Service
{
    public interface IClothingService
    {
        IEnumerable<Clothing> GetClothings();
        Clothing GetClothing(long id);
        void InsertClothing(Clothing clothing);
        void UpdateClothing(Clothing clothing);
        void DeleteClothing(long id);

    }
}
