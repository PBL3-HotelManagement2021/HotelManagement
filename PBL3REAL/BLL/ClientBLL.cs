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
        public void delete(int id)
        {
            try
            {
                _clientDAL.delete(id);
            }
            catch (Exception)
            {

            }

        }


        public void restore(int id)
        {
            try
            {
                _clientDAL.restore(id);
            }
            catch (Exception)
            {

            }
          
        }

        public List<ClientVM> findByProperty(int pages, int rows  ,Dictionary<string ,string> properties, string orderBy)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<ClientVM> listVm = new List<ClientVM>();
            foreach (Client client in _clientDAL.findByProperty(start, length,properties, orderBy))
            {
                ClientVM clientVM = mapper.Map<ClientVM>(client);
                listVm.Add(clientVM);
            }
            return listVm;
        }

        public bool checkexisted(Dictionary<string , string > properties)
        {
            var list = _clientDAL.checkExisted(properties);
            if (list.Count ==0) return true; 
            return false ;
        }

        public ClientVM findById(int id)
        {
            Client client = _clientDAL.findById(id);
            ClientVM clientVM = mapper.Map<ClientVM>(client);
            return clientVM;
        }

        public int getPagination(int rows , Dictionary<string , string> properties)
        {
            int totalRows = _clientDAL.getTotalRow(properties);
            int totalpage ;
            if (totalRows % rows == 0)
            {
                totalpage = totalRows / rows;
            }
            else
            {
                totalpage = totalRows / rows + 1;
            }
            return totalpage;
        }
    }
}
