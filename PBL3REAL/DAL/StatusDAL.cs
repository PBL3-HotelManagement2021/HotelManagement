
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class StatusDAL
    {
        public static StatusDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new StatusDAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static StatusDAL _Instance;
        public StatusDAL()
        {
        }
        public List<Status> getAll()
        {
            var result = AppDbContext.Instance.Statuses.AsNoTracking().ToList();
            return result;
        }
    }
}
