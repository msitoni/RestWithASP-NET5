using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_RestWithASPNET.Model;
using _01_RestWithASPNET.Model.Base;

namespace _01_RestWithASPNET.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        public bool Exists(long id);
    }
}
