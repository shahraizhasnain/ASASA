using SaudaMaster.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Infrastructure.Common
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private saudadbEntities dataContext;
        public saudadbEntities Get()
        {
            return dataContext ?? (dataContext = new saudadbEntities());
        }        

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext = null;
        }
    }
}
