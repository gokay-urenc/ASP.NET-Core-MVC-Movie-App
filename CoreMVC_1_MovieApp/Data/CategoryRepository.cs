using CoreMVC_1_MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC_1_MovieApp.Data
{
    public class CategoryRepository
    {
        private static readonly List<Category> _categories = null;
        
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "Action" },
                new Category() { Id = 2, Name = "Drama" },
                new Category() { Id = 3, Name = "Horror" },
                new Category() { Id = 4, Name = "Animation" },
                new Category() { Id = 5, Name = "Comedy" },
                new Category() { Id = 6, Name = "Sci-Fi" },
                new Category() { Id = 7, Name = "Journey" },
                new Category() { Id = 8, Name = "Child" },
                new Category() { Id = 9, Name = "Romantic" },
                new Category() { Id = 10, Name = "Sport" },
                new Category() { Id = 11, Name = "Western" },
                new Category() { Id = 12, Name = "Crime" },
                new Category() { Id = 13, Name = "Middle Age" }
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        
        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}