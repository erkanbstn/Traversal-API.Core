using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class Repository<T> : IGenericDal<T> where T : class
    {
        VisitorContext c = new VisitorContext();
        DbSet<T> _object;

        public Repository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T t)
        {
            _object.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            _object.Add(t);
            c.SaveChanges();

        }

        public void Update(T t)
        {
            _object.Update(t);
            c.SaveChanges();

        }
    }
}
