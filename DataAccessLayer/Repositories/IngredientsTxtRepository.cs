using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class IngredientsTxtRepository : IIngredientsRepository
    {
        string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "IngredientsStorage.txt");
        public void AddIngredient(Ingredient ingredient)
        {
            int id = Math.Abs(Guid.NewGuid().GetHashCode());

            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine($"{id}|{ingredient.Name}|{ingredient.Weight}|{ingredient.KcalPer100g}|{ingredient.PricePer100g}|{ingredient.Type}");
            }  
        }

        public List<Ingredient> GetIngredients()
        {
            throw new NotImplementedException();
        }
    }
}
