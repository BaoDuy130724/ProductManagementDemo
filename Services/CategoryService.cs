using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository iCategoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            iCategoryRepository = categoryRepository;
        }
        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories();
        }
    }
}
