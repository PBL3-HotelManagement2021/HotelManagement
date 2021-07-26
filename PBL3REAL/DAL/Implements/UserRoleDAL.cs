using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL.Implements
{
    public class UserRoleDAL : IUserRoleDAL
    {
        public void AddUserRole(List<UserRole> list)
        {
            AppDbContext.Instance.UserRoles.AddRange(list);
            AppDbContext.Instance.SaveChanges();
        }
        public void DelUserRole(int idUser)
        {
            var listdel = AppDbContext.Instance.UserRoles.Where(x => x.UserolIduser == idUser).ToList();
            AppDbContext.Instance.RemoveRange(listdel);
            AppDbContext.Instance.SaveChanges();
        }
    }
}
