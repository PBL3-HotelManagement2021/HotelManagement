using AutoMapper;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.DAL;
using PBL3REAL.DAL.Facade;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    public class QLClientBLL : IClientBLL
    {        
        private Mapper mapper;
        private ClientDALManageFacade qLClientFacade;
        public QLClientBLL()
        {
            mapper = new Mapper(MapperVM.config);
            qLClientFacade = new ClientDALManageFacade();
        }
        public void Add(ClientVM clientVM)
        {
            Client client = new Client();
            mapper.Map(clientVM, client);
            qLClientFacade.Add(client);
        }

        public void Update(ClientVM clientVM)
        {
            Client client = new Client();
            mapper.Map(clientVM, client);
            qLClientFacade.Update(client);
        }
        public void Delete(int id)
        {
            try
            {
                qLClientFacade.Delete(id);
            }
            catch (Exception)
            {

            }

        }


        public void Restore(int id)
        {
            try
            {
                qLClientFacade.Restore(id);
            }
            catch (Exception)
            {

            }          
        }

        public List<ClientVM> FindByProperty(int pages, int rows  ,Dictionary<string ,string> properties, string orderBy)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<ClientVM> listVm = new List<ClientVM>();
            foreach (Client client in qLClientFacade.findByProperty(start, length,properties, orderBy))
            {
                ClientVM clientVM = mapper.Map<ClientVM>(client);
                clientVM.Index = ++start;
                listVm.Add(clientVM);
            }
            return listVm;
        }

        public bool Checkexisted(Dictionary<string , string > properties)
        {
            var list = qLClientFacade.checkExisted(properties);
            if (list.Count ==0) return true; 
            return false ;
        }

        public ClientVM FindById(int id)
        {
            Client client = qLClientFacade.findById(id);
            ClientVM clientVM = mapper.Map<ClientVM>(client);
            return clientVM;
        }

        public int GetPagination(int rows , Dictionary<string , string> properties)
        {
            int totalRows = qLClientFacade.getTotalRow(properties);
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
