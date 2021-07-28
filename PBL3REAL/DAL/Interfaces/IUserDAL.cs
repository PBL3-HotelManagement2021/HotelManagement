using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IUserDAL : SharedInterface<User>
    {
        public List<User> FindByProperty(Dictionary<string, string> properties, string orderBy);
        public List<User> CheckExisted(Dictionary<string, string> properties);

    }
}
