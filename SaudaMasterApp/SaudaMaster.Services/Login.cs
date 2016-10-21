using System;
using SaudaMaster.Adapter;
using SaudaMaster.SharedModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Services
{
   public class LoginService : ILoginService
    {
        LoginAdapter loginAdapter;

        public LoginService()
        {
            loginAdapter = new LoginAdapter();
        }
        public LoginViewModel Authenticate(LoginViewModel loginViewModel)
        {
            return loginAdapter.Authenticate(loginViewModel);
        }
    } 

    public interface ILoginService
    {
        LoginViewModel Authenticate(LoginViewModel loginViewModel);
    }
}
