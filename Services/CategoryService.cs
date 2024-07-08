using Microsoft.EntityFrameworkCore;
using TP2Core.Models;
using TP2Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TP2Core.Services
{
    public class CategoryService : ICategoryInterface
    {
        private readonly ApplicationDbContext _db;
        public CategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Categorie> CreateCategory(Categorie category)
        {
            _db.categorie.Add(category);
            await _db.SaveChangesAsync();
            return category;
        }

        public async Task<Categorie> DeleteCategory(int id)
        {
            var catInDb = await _db.categorie.FindAsync(id);
            _db.categorie.Remove(catInDb);
            await _db.SaveChangesAsync();
            return catInDb;
        }

        public async Task<Categorie> EditCategory(int id, Categorie category)
        {
            var catInDb = await _db.categorie.FindAsync(id);
            catInDb.Name = category.Name;
            catInDb.SousCategories = category.SousCategories;
            await _db.SaveChangesAsync();
            return catInDb;
        }

        public async Task<IEnumerable<Categorie>> GetAllCategories()
        {
            return await _db.categorie.Include(c => c.SousCategories).ToListAsync();
        }
    }
}