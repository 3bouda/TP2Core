using System.Collections.Generic;
using System.Threading.Tasks;
using TP2Core.Models;

namespace TP2Core.Repositories
{
    public interface ICategoryInterface
    {
        Task<IEnumerable<Categorie>> GetAllCategories();
        Task<Categorie> CreateCategory(Categorie category);
        Task<Categorie> EditCategory(int id, Categorie category);
        Task<Categorie> DeleteCategory(int id);
    }
}