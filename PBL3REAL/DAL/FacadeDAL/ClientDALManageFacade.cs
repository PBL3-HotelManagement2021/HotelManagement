using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Facade
{
    public class ClientDALManageFacade
    {
        private IClientDAL _clientDALProvider;

        public ClientDALManageFacade()
        {
            _clientDALProvider = new ClientDAL();
        }

        public int Add(Client client) {
            return _clientDALProvider.Add(client);
        }
        public int Update(Client client)
        {
            return _clientDALProvider.Update(client);
        }
        public void Delete(int id)
        {
             _clientDALProvider.Delete(id);
        }

        public void Restore(int id)
        {
             _clientDALProvider.Restore(id);
        }

      

        public List<Client> findByProperty(int start, int length, Dictionary<string, string> properties, string orderBy)
        {
            return _clientDALProvider.FindByProperty(start, length, properties, orderBy);
        }

        public int getTotalRow(Dictionary<string, string> properties)
        {
            return _clientDALProvider.GetTotalRow(properties);
        }


        public List<Client> checkExisted(Dictionary<string, string> properties)
        {
            return _clientDALProvider.CheckExisted(properties);
        }
        public Client findById(int id)
        {
            return _clientDALProvider.FindById(id);
        }
    }
}
