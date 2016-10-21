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
    public class BrandAdapter
    {
        private IBrandRepository BrandRepository;
        private IUnityOfWork UnityOfWork;

        public BrandAdapter()
        {
            UnityOfWork = new UnityOfWork(new DatabaseFactory());
            BrandRepository = new BrandRepository(UnityOfWork.instance);
        }

        public void CreateBrand(BrandViewModel brandViewModel)
        {
            Brand brand = new Brand()
            {
                BrandID = brandViewModel.BrandID,
                BrandTitle = brandViewModel.BrandTitle,
                BrandName = brandViewModel.BrandName,
                BrandDescription = brandViewModel.BrandDescription,
                BrandImage = brandViewModel.BrandImage
            };
            BrandRepository.Add(brand);
            UnityOfWork.Commit();
        }

        public IEnumerable<BrandViewModel> ReturnAllBrands()
        {
            var brands = BrandRepository.GetAll();
            List<BrandViewModel> result = new List<BrandViewModel>();
            foreach(var item in brands)
            {
                result.Add(new BrandViewModel
                {
                    BrandID = item.BrandID,
                    BrandName = item.BrandName,
                    BrandDescription = item.BrandDescription,
                    BrandTitle = item.BrandTitle,
                    BrandImage = item.BrandImage,
                });
            }
            return result;
        }

        public void EditBrand(int BrandID)
        {
            var getbrand = BrandRepository.GetById(BrandID);
            Brand brand = new Brand();
            brand.BrandID = getbrand.BrandID;
            brand.BrandName = getbrand.BrandName;
            brand.BrandTitle = getbrand.BrandTitle;
            brand.BrandDescription = getbrand.BrandDescription;
            brand.BrandImage = getbrand.BrandImage;

            BrandRepository.Update(brand);
            UnityOfWork.Commit();
        }

        public void EditBrand(BrandViewModel brandViewModel)
        {
            Brand brand = new Brand();
            brand.BrandID = brandViewModel.BrandID;
            brand.BrandName = brandViewModel.BrandName;
            brand.BrandTitle = brandViewModel.BrandTitle;
            brand.BrandDescription = brandViewModel.BrandDescription;
            brand.BrandImage = brandViewModel.BrandImage;

            BrandRepository.Update(brand);
            UnityOfWork.Commit();
        }

        public void DeleteBrand(int BrandID)
        {
            BrandRepository.Delete(BrandRepository.GetById(BrandID));
            UnityOfWork.Commit();
        }
        

    }
}
