using AutoMapper;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    public class ClientBLL
    {
        private ClientDAL _clientDAL;
        
        private Mapper mapper;
        public ClientBLL()
        {
            mapper = new Mapper(MapperVM.config);
            _clientDAL = new ClientDAL();
        }
        public void add(ClientVM clientVM)
        {
            Client client = new Client();
            mapper.Map(clientVM, client);
            _clientDAL.add(client);
        }

        public void update(ClientVM clientVM)
        {
            Client client = new Client();
            mapper.Map(clientVM, client);
            _clientDAL.update(client);
        }

        public List<ClientVM> findByProperty(Dictionary<string ,string> properties, string orderBy)
        {
            List<ClientVM> listVm = new List<ClientVM>();
            foreach (Client client in _clientDAL.findByProperty(properties,orderBy))
            {
                ClientVM clientVM = mapper.Map<ClientVM>(client);
                listVm.Add(clientVM);
            }
            return listVm;
        }

        public bool checkexisted(Dictionary<string , string > properties , string code)
        {
            var list = _clientDAL.checkExisted(properties);
            /*  if (list == null) return true;
              else if (list != null && list.Find(x => x.CliCode == code) != null)
              {
                  var check = list.Find(x => x.CliCode == code);

              }*/
            if (list.Count ==0) return true; 
            return false ;
        }

        public ClientVM findById(int id)
        {
            Client client = _clientDAL.findById(id);
            ClientVM clientVM = mapper.Map<ClientVM>(client);
            return clientVM;
        }
    }
}
