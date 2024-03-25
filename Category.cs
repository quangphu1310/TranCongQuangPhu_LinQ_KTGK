using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranCongQuangPhu_LinQ_KTGK
{
    class Category
    {
        public int Id { get; set; }
        public string NameCate { get; set; }
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, NameCate = "Book" },
                new Category { Id = 2, NameCate = "Newspaper" },
                new Category { Id = 3, NameCate= "Magazine" }
            };
        }
    }
}
