using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using VBHA_Hockey_App.Models;

namespace ODG.Core45
{
    public class EntityFramework6Repository : EntityFramework6RepositoryBase, IEntityFramework6Repository
    {
        protected prestonjang_VBHA_HockeyAppEntities _context;

        public EntityFramework6Repository(prestonjang_VBHA_HockeyAppEntities context)
        {
            _context = context;
        }

        public override IQueryable<T> GetAll<T>()
        {
            return _context.Set<T>();
        }



        public override T GetByID<T>(int id)
        {
            return _context.Set<T>().Find(id);
        }



        public override T Create<T>(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
            return t;
        }



        public override T Update<T>(T entityToEdit, string KeyFieldName = "ID")
        {
            if (entityToEdit == null)
                return null;


            int id = 0;
            id = (int)typeof(T).GetProperty(KeyFieldName).GetValue(entityToEdit, null);

            T existing = _context.Set<T>().Find(id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(entityToEdit);
                _context.SaveChanges();
            }
            return existing;
        }



        public override void Delete<T>(T t)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }



    }
}