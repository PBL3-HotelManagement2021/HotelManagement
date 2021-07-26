using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IUserRoleDAL
    {
        public void AddUserRole(List<UserRole> list);
        public void DelUserRole(int idUser);
    }
}
