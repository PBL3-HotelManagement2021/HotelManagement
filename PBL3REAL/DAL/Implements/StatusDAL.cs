
using Microsoft.EntityFrameworkCore;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class StatusDAL : IStatusDAL
    {
      
        public StatusDAL()
        {
        }

        public int Add(Status t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Status FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Status> GetAll()
        {
            var result = AppDbContext.Instance.Statuses.AsNoTracking().ToList();
            return result;
        }

        public int GetNextId()
        {
            throw new NotImplementedException();
        }

        public void Restore(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Status t)
        {
            throw new NotImplementedException();
        }
    }
}
