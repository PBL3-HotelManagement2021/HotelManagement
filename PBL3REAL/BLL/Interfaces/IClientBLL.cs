using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.Interfaces
{
    interface IClientBLL
    {
        public void Add(ClientVM clientVM);
        public void Update(ClientVM clientVM);
        public void Delete(int id);
        public void Restore(int id);
        public List<ClientVM> FindByProperty(int pages, int rows, Dictionary<string, string> properties, string orderBy);
        public bool Checkexisted(Dictionary<string, string> properties);
        public ClientVM FindById(int id);
        public int GetPagination(int rows, Dictionary<string, string> properties);



        }
}
