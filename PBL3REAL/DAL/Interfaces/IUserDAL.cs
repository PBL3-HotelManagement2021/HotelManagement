using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IUserDAL
    {
        public User FindById(int id);
        public List<User> FindByProperty(Dictionary<string, string> properties, string orderBy);
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void DelUser(int idUser);
        public void RestoreUser(int idUser);
        public List<User> CheckExisted(Dictionary<string, string> properties);
        public int Getnextid();

    }
}
