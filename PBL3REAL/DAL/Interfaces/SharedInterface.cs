using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface SharedInterface <T> where T : class
    {
        int Add(T t);
        int Update(T t);
        void Delete(int id);
        void Restore(int id);
        T FindById(int id);
        List<T> GetAll();
        int GetNextId();
    }
}
