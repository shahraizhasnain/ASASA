using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaudaMaster.Adapter;
using SaudaMaster.SharedModel;


namespace SaudaMaster.Services
{
    public class SubCategoryServices : ISubCategoryService
    {
        SubCategoryAdapter subcategoryadapter;
        public SubCategoryServices()
        {
            this.subcategoryadapter = new SubCategoryAdapter();
        }

        public IEnumerable<SubCategoryViewModel> ReturnAllSubCategory()
        {
            return subcategoryadapter.ReturnAllSubCategory();
        }

        public void CreateSubCategory(SubCategoryViewModel subcategoryViewModel)
        {
            subcategoryadapter.CreateSubCategory(subcategoryViewModel);
        }
    }
    public interface ISubCategoryService
    {
        void CreateSubCategory(SubCategoryViewModel subcategoryViewModel);
        IEnumerable<SubCategoryViewModel> ReturnAllSubCategory();
        //BrandViewModel EditBrand(int BrandID);
        //void EditBrand(BrandViewModel brandViewModel);
        //void DeleteBrand(int BrandID);
        //bool CheckDuplicate(BrandViewModel brand);
        //bool CheckDuplicateForUpdate(string brand, int id);
    }
}

