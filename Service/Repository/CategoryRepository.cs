using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository() { }

        public Category getCategoryById(int id)
        {
            Category category = new Category();
            category = this.getAll().FirstOrDefault(p => p.Id == id,null);
            return category;
        }
    }
}
