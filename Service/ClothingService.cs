using System;
using System.Collections.Generic;
using System.Text;
using FreakyFashion.Data.Models;
using FreakyFashion.Repo;

namespace FreakyFashion.Service
{
    public class ClothingService : IClothingService
    {

        private IRepository<Clothing> clothingRepository;

        public ClothingService(IRepository<Clothing> clothingRepository)
        {
            this.clothingRepository = clothingRepository;
        }

        public IEnumerable<Clothing> GetClothings()
        {
            return clothingRepository.GetAll();
        }

        public Clothing GetClothing(long id)
        {
            return clothingRepository.Get(id);
        }

        public void InsertClothing(Clothing clothing)
        {
            clothingRepository.Insert(clothing);
        }
        public void UpdateClothing(Clothing clothing)
        {
            clothingRepository.Update(clothing);
        }

        public void DeleteClothing(long id)
        {
            Clothing clothing = GetClothing(id);
            clothingRepository.Remove(clothing);
            clothingRepository.SaveChanges();
        }
    }
}
