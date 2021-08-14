using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HotelManagement.Extention;
using PBL3REAL.DAL.Interfaces;

namespace PBL3REAL.DAL
{
    public class ClientDAL : IClientDAL
    {
     
        public ClientDAL()
        {
        }

        public int Add(Client client)
        {
            int trackedID = 0;
            client.CliActiveflag = true;
            AppDbContext.Instance.Clients.Add(client);
            AppDbContext.Instance.SaveChanges();
            trackedID = client.IdClient;
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
            return trackedID;
        }
        public int Update(Client client)
        {
            int trackedID = 0;
            client.CliActiveflag = true;
            AppDbContext.Instance.Clients.Update(client);
            AppDbContext.Instance.SaveChanges();
            trackedID = client.IdClient;
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
            return trackedID;
        }

        public void Delete(int id)
        {
            Client client = FindById(id);
            client.CliActiveflag = false;
            AppDbContext.Instance.Clients.Update(client);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
        }

       

        public void Restore(int id)
        {
            Client client = FindById(id);
            client.CliActiveflag = true;
            AppDbContext.Instance.Clients.Update(client);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(client).State = EntityState.Detached;
        }


        public List<Client> FindByProperty(int start, int length ,Dictionary<string, string> properties , string orderBy)
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

        public int GetTotalRow(Dictionary<string, string> properties)
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

        public List<Client> CheckExisted(Dictionary<string , string > properties)
        {
            var predicate = PredicateBuilder.True<Client>();
            var predicate2 = PredicateBuilder.True<Client>();
            if (properties.ContainsKey("phone") && properties.ContainsKey("gmail"))
                predicate = predicate.And(x => x.CliPhone == properties["phone"] || x.CliGmail == properties["gmail"] );
            if (properties.ContainsKey("code") && properties["code"] !="")
            {
       //         predicate2 = predicate2.And(x => x.Code == properties["code"]);
                predicate = predicate.And(x => x.CliCode != properties["code"]); 
            }                
            var result = AppDbContext.Instance.Clients.Where(predicate).AsNoTracking().ToList();
            return result;
        }
        public Client FindById(int id)
        {
            return AppDbContext.Instance.Clients.Where(x => x.IdClient == id).AsNoTracking().SingleOrDefault();
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetNextId()
        {
            throw new NotImplementedException();
        }
    }
}
