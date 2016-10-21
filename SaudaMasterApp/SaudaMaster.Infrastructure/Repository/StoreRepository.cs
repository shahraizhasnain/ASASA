using System;
using SaudaMaster.Data;
using SaudaMaster.Infrastructure.Common;
using SaudaMaster.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Infrastructure.Repository
{
    public class StoreRepository : RepositoryBase<Store>, IStoreRepository
    {
        public StoreRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {


        }



    }
    public interface IStoreRepository : IRepository<Store>
    {

    }

}
