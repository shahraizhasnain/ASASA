using SaudaMaster.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SaudaMaster.Infrastructure.Common
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private saudadbEntities dataContext;

        public UnityOfWork (IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected saudadbEntities DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }

        public IDatabaseFactory instance
        {
            get
            {
                return databaseFactory;
            }
        }

        public saudadbEntities db
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
    }
}
