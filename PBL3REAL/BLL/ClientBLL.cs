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
        private Mapper mapper;
        public ClientBLL()
        {
            mapper = new Mapper(MapperVM.config);
        }

        public void add(ClientVM clientVM)
        {
            Client client = new Client();
            mapper.Map(clientVM, client);
            ClientDAL.Instance.add(client);
        }

        public void update(ClientVM clientVM)
        {
            Client client = new Client();
            mapper.Map(clientVM, client);
            ClientDAL.Instance.update(client);
        }
        public void delete(int id)
        {
            try
            {
                ClientDAL.Instance.delete(id);
            }
            catch (Exception)
            {

            }
        }

        public void restore(int id)
        {
            try
            {
                ClientDAL.Instance.restore(id);
            }
            catch (Exception)
            {

            }
        }


    }
}
