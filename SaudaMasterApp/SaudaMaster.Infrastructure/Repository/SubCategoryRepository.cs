using System;
using SaudaMaster.Data;
using SaudaMaster.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Infrastructure.Repository
{
    public class SubCategoryRepository : RepositoryBase<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISubCategoryRepository : IRepository<SubCategory>
    {

    }
}

