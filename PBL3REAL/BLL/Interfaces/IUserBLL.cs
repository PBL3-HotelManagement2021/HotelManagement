using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.Interfaces
{
    interface IUserBLL
    {
        public List<UserVM> FindByProperty(Dictionary<string, string> search, string orderBy);
        public bool Checkexisted(Dictionary<string, string> properties);
        public UserVM FindDetailUser(int id);
        public UserVM CheckUser(Dictionary<string, string> properties);
        public void DelUser(int idUser);
        public void RestoreUser(int idUser);
        public void UpdateUser(UserVM userVM, List<int> listdel, bool isPassChanged);
        public void AddUser(UserVM userVM);
        public List<RoleVM> GetRoleForUser();

    }
}
