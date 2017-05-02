using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace ODG.Core45
{
    public abstract class EntityFramework6RepositoryBase : IEntityFramework6Repository
    {

        #region IGenericRepository Members

        public abstract IQueryable<T> GetAll<T>() where T : class;




        public abstract T GetByID<T>(int id) where T : class;








        public abstract T Create<T>(T t) where T : class;





        public abstract T Update<T>(T entityToEdit, string KeyFieldName = "ID") where T : class;




        public abstract void Delete<T>(T t) where T : class;





        #endregion
    }
}