using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CronusWebApplication.Repository
{
    public interface IRepository<T> where T : class
    {
        string Create(T obj);
        T Retrieve(string key);
        void Update(T obj);
        void Delete(string key);

        T GetEntities(string selectedTable);
    }
}