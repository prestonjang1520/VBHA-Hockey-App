using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace ODG.Core45
{
    public interface IEntityFramework6Repository
    {
        IQueryable<T> GetAll<T>() where T : class;




        T GetByID<T>(int id) where T : class;





        T Create<T>(T t) where T : class;





        T Update<T>(T entityToEdit, string KeyFieldName = "ID") where T : class;



        void Delete<T>(T t) where T : class;



    }
}