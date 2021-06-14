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
        public static ClientDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ClientDAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static ClientDAL _Instance;
        public ClientDAL()
        {
        }

        public int add(Client client)
        {
            client.CliActiveflag = true;
            AppDbContext.Instance.Clients.Add(client);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
            return client.IdClient;
        }
        public int update(Client client)
        {
            client.CliActiveflag = true;
            AppDbContext.Instance.Clients.Update(client);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
            return client.IdClient;
        }

        public void delete(int id)
        {
            Client client = findById(id);
            client.CliActiveflag = false;
            AppDbContext.Instance.Clients.Update(client);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
        }

        public void restore(int id)
        {
            Client client = findById(id);
            client.CliActiveflag = true;
            AppDbContext.Instance.Clients.Update(client);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
        }


        public List<Client> findByProperty(int start, int length ,Dictionary<string, string> properties , string orderBy)
        {
            var predicate = PredicateBuilder.True<Client>();
            if (properties.ContainsKey("name"))
                predicate = predicate.And(x => x.CliName.Contains(properties["name"]));           
            if (properties.ContainsKey("code"))            
                predicate = predicate.And(x => x.CliCode == properties["code"]);
            if(properties.ContainsKey("phone"))
                predicate = predicate.And(x => x.CliPhone == properties["phone"]);
            if (properties.ContainsKey("gmail"))
                predicate = predicate.And(x => x.CliGmail == properties["gmail"]);
            if (properties.ContainsKey("status"))
            {
                if(properties["status"]=="Active") predicate = predicate.And(x => x.CliActiveflag == true);
                else predicate = predicate.And(x => x.CliActiveflag == false);
            }

            IQueryable<Client> query = AppDbContext.Instance.Clients
                                      .Where(predicate);
            switch (orderBy)
            {
                case "None": break;
                case "Name Asc": query = query.OrderBy(x => x.CliName); break;
                case "Name Desc": query = query.OrderByDescending(x => x.CliName); break;
                default: break;
            }
            List<Client> result = query.Skip(start).Take(length).AsNoTracking().ToList();
            return result;
        }

        public int getTotalRow(Dictionary<string, string> properties)
        {
            var predicate = PredicateBuilder.True<Client>();
            if (properties.ContainsKey("name"))
                predicate = predicate.And(x => x.CliName.Contains(properties["name"]));
            if (properties.ContainsKey("code"))
                predicate = predicate.And(x => x.CliCode == properties["code"]);
            if (properties.ContainsKey("phone"))
                predicate = predicate.And(x => x.CliPhone == properties["phone"]);
            if (properties.ContainsKey("gmail"))
                predicate = predicate.And(x => x.CliGmail == properties["gmail"]);
            if (properties.ContainsKey("status"))
            {
                if (properties["status"] == "Active") predicate = predicate.And(x => x.CliActiveflag == true);
                else predicate = predicate.And(x => x.CliActiveflag == false);
            }
           int result = AppDbContext.Instance.Clients.Where(predicate).Count();
            return result;
        }

        public List<Client> checkExisted(Dictionary<string , string > properties)
        {
            var predicate = PredicateBuilder.True<Client>();
            var predicate2 = PredicateBuilder.True<Client>();
            if (properties.ContainsKey("phone") && properties.ContainsKey("gmail"))
                predicate = predicate.And(x => x.CliPhone == properties["phone"] || x.CliGmail == properties["gmail"] );
            if (properties.ContainsKey("code") && properties["code"] !="")
            {
       //         predicate2 = predicate2.And(x => x.CliCode == properties["code"]);
                predicate = predicate.And(x => x.CliCode != properties["code"]); 
            }                
            var result = AppDbContext.Instance.Clients.Where(predicate).AsNoTracking().ToList();
            return result;
        }
        public Client findById(int id)
        {
            return AppDbContext.Instance.Clients.Where(x => x.IdClient == id).AsNoTracking().SingleOrDefault();
        }
    }
}
