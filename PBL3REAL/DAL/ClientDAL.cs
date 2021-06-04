using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HotelManagement.Extention;

namespace PBL3REAL.DAL
{
    class ClientDAL
    {
        private AppDbContext _appDbContext;
        public ClientDAL()
        {
            _appDbContext = new AppDbContext(); 
        }

        public int add(Client client)
        {
            client.CliActiveflag = true;
            _appDbContext.Clients.Add(client);
            _appDbContext.SaveChanges();
            return client.IdClient;
        }
        public int update(Client client)
        {
            client.CliActiveflag = true;
            _appDbContext.Clients.Update(client);
            _appDbContext.SaveChanges();
            return client.IdClient;
        }


        public List<Client> findByProperty(Dictionary<string, string> properties , string orderBy)
        {
            var predicate = PredicateBuilder.True<Client>();
            if (properties.ContainsKey("name"))
                predicate = predicate.And(x => x.CliName.Contains(properties["name"]));           
            if (properties.ContainsKey("code"))            
                predicate = predicate.And(x => x.CliCode == properties["code"]);
            if(properties.ContainsKey("phone"))
                predicate = predicate.And(x => x.CliPhone == properties["phone"]);

            predicate = predicate.And(x => x.CliActiveflag == true);

            IQueryable<Client> query = AppDbContext.Instance.Clients
                                      .Where(predicate);
            switch (orderBy)
            {
                case "None": break;
                case "Name Asc": query = query.OrderBy(x => x.CliName); break;
                case "Name Desc": query = query.OrderByDescending(x => x.CliName); break;
                default: break;
            }

            List<Client> result = query.AsNoTracking().ToList();
            return result;
        }

        public Client findById(int id)
        {
            return AppDbContext.Instance.Clients.Where(x => x.IdClient == id).SingleOrDefault();
        }
    }
}
