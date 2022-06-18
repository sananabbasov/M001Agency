using Agency.Models;
using Microsoft.EntityFrameworkCore;

namespace Agency.Data
{
    public class DataSeeding
    {
        private readonly AppDbContext _context;
        public DataSeeding(AppDbContext context)
        {
            _context = context;
        }
        public void SeedData()
        {
            if (_context.Database.GetPendingMigrations().Count() == 0)
            {
                if (_context.Categories.Count() == 0)
                {
                    _context.Categories.AddRange(Categories);
                }
                if (_context.Portfolios.Count() == 0)
                {
                    _context.Portfolios.AddRange(Portfolios);
                }
                _context.SaveChanges();
            }
        }

        public static Category[] Categories =
        {
            new Category() { Name = "Illustration"},
            new Category() { Name = "Graphic Design"},
            new Category() { Name = "Website Design"}
        };
        public static Portfolio[] Portfolios =
        {
            new Portfolio()
            {
                Title = "Basliq 1",
                Description = "Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!",
                PhotoURL= "https://cdn.pixabay.com/photo/2022/05/24/09/48/sky-7218043_960_720.jpg",
                Client="Musteri 1",
                Category = Categories[0]
            },
            new Portfolio()
            {
                Title = "Basliq 2",
                Description = "Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!",
                PhotoURL= "https://cdn.pixabay.com/photo/2019/10/18/05/04/tent-4558240_960_720.jpg",
                Client="Musteri 2",
                Category = Categories[1]
            },
            new Portfolio()
            {
                Title = "Basliq 3",
                Description = "Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!",
                PhotoURL= "https://cdn.pixabay.com/photo/2022/05/23/13/09/grass-7216163_960_720.jpg",
                Client="Muster 3",
                Category = Categories[1]
            },

        };
    }
}
