using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaudaMaster.Infrastructure.Common;
using SaudaMaster.Infrastructure.Repository;
using SaudaMaster.SharedModel;
using SaudaMaster.Data;

namespace SaudaMaster.Adapter
{
    public class SubCategoryAdapter
    {
        private ISubCategoryRepository SubCategoryRepository;
        private IUnityOfWork UnityOfWork;


        public SubCategoryAdapter()
        {
            UnityOfWork = new UnityOfWork(new DatabaseFactory());
            SubCategoryRepository = new SubCategoryRepository(UnityOfWork.instance);
        }

        public void CreateSubCategory(SubCategoryViewModel SubCategoryViewModel)
        {
            SubCategory subcategory = new SubCategory()
            {
                SubCategoryID = SubCategoryViewModel.SubCategoryID,
                CategoryID = 1, /*SubCategoryViewModel.CategoryID,*/

                SubCategoryDisplayName = SubCategoryViewModel.SubCategoryDisplayName,
                SubCategoryName = SubCategoryViewModel.SubCategoryName,
                SubCategoryImage = SubCategoryViewModel.SubCategoryImage,
            };
            SubCategoryRepository.Add(subcategory);
            UnityOfWork.Commit();


        }

        public IEnumerable<SubCategoryViewModel> ReturnAllSubCategory()
        {
            var subcategory = SubCategoryRepository.GetAll();
            List<SubCategoryViewModel> result = new List<SubCategoryViewModel>();
            foreach (var item in subcategory)
            {
                result.Add(new SubCategoryViewModel
                {
                    SubCategoryID = item.SubCategoryID,
                    SubCategoryName = item.SubCategoryName,
                    CategoryID = item.CategoryID,
                    SubCategoryDisplayName = item.SubCategoryDisplayName,
                    SubCategoryImage = item.SubCategoryImage,

                });
            }
            return result;
        }

        public void EditSubCategory(int SubCategoryID)
        {
            var getSubcategory = SubCategoryRepository.GetById(SubCategoryID);
            SubCategory subcategory = new SubCategory();
            subcategory.SubCategoryID = getSubcategory.SubCategoryID;
            subcategory.SubCategoryName = getSubcategory.SubCategoryName;
            subcategory.SubCategoryDisplayName = getSubcategory.SubCategoryDisplayName;
            subcategory.SubCategoryImage = getSubcategory.SubCategoryImage;
            subcategory.CategoryID = getSubcategory.CategoryID;
            // subcategory.Category = getSubcategory.Category;

            SubCategoryRepository.Update(subcategory);
            UnityOfWork.Commit();
        }

        public void EditSubCategory(SubCategoryViewModel SubCategoryViewModel)
        {
            SubCategory subcategory = new SubCategory();
            subcategory.SubCategoryID = SubCategoryViewModel.SubCategoryID;
            subcategory.SubCategoryName = SubCategoryViewModel.SubCategoryName;
            subcategory.SubCategoryDisplayName = SubCategoryViewModel.SubCategoryDisplayName;
            subcategory.SubCategoryImage = SubCategoryViewModel.SubCategoryImage;
            subcategory.CategoryID = SubCategoryViewModel.CategoryID;

            SubCategoryRepository.Update(subcategory);
            UnityOfWork.Commit();
        }

        public void DeleteSubCategory(int SubCategoryID)
        {
            SubCategoryRepository.Delete(SubCategoryRepository.GetById(SubCategoryID));
            UnityOfWork.Commit();
        }


    }
}