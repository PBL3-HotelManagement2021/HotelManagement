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
    }
}
