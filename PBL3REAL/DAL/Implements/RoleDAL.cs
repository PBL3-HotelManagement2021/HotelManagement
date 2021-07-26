using Microsoft.EntityFrameworkCore;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL
{
    public class RoleDAL : IRoleDAL
    {
      

        public RoleDAL() { }

        public List<Role> GetAll()
        {
            var result = AppDbContext.Instance.Roles.AsNoTracking().ToList();
            return result;
        }

        public Role GetDetail(int idRole)
        {
            Role result = AppDbContext.Instance.Roles.Include(x=>x.Permissions).ThenInclude(y =>y.PerIdactionNavigation).Where(x=>x.IdRole == idRole).AsNoTracking().FirstOrDefault();
            foreach (var permission in result.Permissions.ToList())
            {
                if (permission.PerActiveflag == false) result.Permissions.Remove(permission);
            }
            return result;
        }
    }
}
