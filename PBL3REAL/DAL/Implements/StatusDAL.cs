
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
        public List<Status> GetAll()
        {
            var result = AppDbContext.Instance.Statuses.AsNoTracking().ToList();
            return result;
        }
    }
}
