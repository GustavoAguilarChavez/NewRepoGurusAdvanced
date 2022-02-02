using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusUAMCommon.Entities;

namespace TecGurusUAMCommon.Interfaces
{
    public interface IEfRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Create(T item);
        T GetById(int id);
        void Update(T item);
        void Delete(T item);
        void Save();

    }
}
