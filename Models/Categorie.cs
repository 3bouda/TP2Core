namespace TP2Core.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SousCategorie> SousCategories { get; set; }
    }
}
