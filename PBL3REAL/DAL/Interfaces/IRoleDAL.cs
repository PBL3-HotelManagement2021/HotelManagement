using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IRoleDAL
    {
        public List<Role> GetAll();
        public Role GetDetail(int idRole);

    }
}
