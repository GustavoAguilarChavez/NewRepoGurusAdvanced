using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusUAMCommon.Entities;
using TecGurusUAMCommon.Interfaces;

namespace TecGurusUAMInfrastructure
{
    public class EfRepository<T> : IEfRepository<T> where T : BaseEntity
    {
        private readonly DBContextUAM _dbContextUAM;
        private DbSet<T> _entities;

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _dbContextUAM.Set<T>();
                return _entities;
            }
        }


        public EfRepository(DBContextUAM dBContext)
        {
            _dbContextUAM = dBContext;
        }



        public IEnumerable<T> GetAll()
        {
            return _dbContextUAM.Set<T>().AsEnumerable().Where(w => w.IsDeleted != null && w.IsDeleted != true);
        }

        public T Create(T item)
        {
            item.IsDeleted = false;
            item.DateCreated = DateTime.Now;
            item.DateModified = DateTime.Now;
            return this.Entities.Add(item).Entity;

        }
        public void Update(T item)
        {
            item.IsDeleted = false;
            item.DateModified = DateTime.Now;
            _dbContextUAM.Entry(item).State = EntityState.Modified;

        }

        public void Delete(T item)
        {
            item.IsDeleted = true;
            item.DateModified = DateTime.Now;
            _dbContextUAM.Entry(item).State = EntityState.Modified;

        }

        public T GetById(int id)
        {
            return Entities.Find(id);
        }

        public void Save()
        {
            _dbContextUAM.SaveChanges();
        }

        //public void SaveId()
        //{
        //    using (var context = new MyContext())
        //    {
        //        context.MyEntities.Add(myNewObject);
        //        context.SaveChanges();

        //        int id = myNewObject.Id; // Yes it's here
        //    }
        //    _dbContextUAM.SaveChanges();
        //}



    }
}