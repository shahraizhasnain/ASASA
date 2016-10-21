using SaudaMaster.Infrastructure.Common;
using SaudaMaster.Infrastructure.Repository;
using SaudaMaster.SharedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Adapter
{
    public class LoginAdapter
    {
        private IStoreRepository StoreRepository;
        private IUnityOfWork unitofwork;

        public LoginAdapter()
        {
            unitofwork = new UnityOfWork(new DatabaseFactory());
            StoreRepository = new StoreRepository(unitofwork.instance);
        }

        public LoginViewModel Authenticate(LoginViewModel loginViewModel)
        {
            var result = (from users in unitofwork.db.Stores
                          where users.StoreUsername == loginViewModel.StoreUsername && users.StorePassword == loginViewModel.StorePassword
                          select users).ToList();


            if (result.Count  > 0)
            {
                var model = result.FirstOrDefault();

                LoginViewModel viewmodel = new LoginViewModel()
                {
                    StoreID = model.StoreID,
                    StoreUsername = model.StoreUsername,
                    StorePassword = model.StorePassword
                };

                return viewmodel;
            }
            else
            {
                return new LoginViewModel();
            }

        }
    }
}
