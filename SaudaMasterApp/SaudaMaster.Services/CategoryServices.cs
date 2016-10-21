using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaudaMaster.Adapter;
using SaudaMaster.SharedModel;

namespace SaudaMaster.Services
{
    public class CategoryServices : ICategoryService
    {
        CategoryAdapter CategoryAdapter;
        public CategoryServices()
        {
            this.CategoryAdapter = new CategoryAdapter();
        }  

        public IEnumerable<CategoryViewModel> ReturnAllCategories()
        {
            return CategoryAdapter.ReturnAllCategories();
        }

        public void CreateCategory(CategoryViewModel CategoryViewModel)
        {
            CategoryAdapter.CreateCategory(CategoryViewModel);
        }
    }


    


    public interface ICategoryService
    {
        void CreateCategory(CategoryViewModel CategoryViewModel);
        IEnumerable<CategoryViewModel> ReturnAllCategories();
    }
}
