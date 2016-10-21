using System;
using SaudaMaster.Data;
using SaudaMaster.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Infrastructure.Repository
{
    public class CategoryRepository : RepositoryBase<Category>,ICategoryRepository
    {
    
    
        public CategoryRepository (IDatabaseFactory databaseFactory)
            :base (databaseFactory)
        {

        }
    }

    public interface ICategoryRepository : IRepository<Category>
    {

    }
}
