using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IClientDAL : SharedInterface<Client>
    {
/*        public int Add(Client client);
        public int Update(Client client);
        public void Delete(int id);
        public void Restore(int id);*/

        public List<Client> FindByProperty(int start, int length, Dictionary<string, string> properties, string orderBy);

        public int GetTotalRow(Dictionary<string, string> properties);

        public List<Client> CheckExisted(Dictionary<string, string> properties);
/*        public Client FindById(int id);*/

    }
}
