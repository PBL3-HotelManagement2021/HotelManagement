using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL
{
    public class UserDAL
    {

        public List<User> getall()
        {
            List<User> result = AppDbContext.Instance.Users
                                .Include(x => x.UserRoles)
                                .ThenInclude(y =>y.UserolIdroleNavigation)
                                .ToList();
            return result;
        }
    }
}
