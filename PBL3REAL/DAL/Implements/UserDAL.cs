using HotelManagement.Extention;
using Microsoft.EntityFrameworkCore;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL
{
    public class UserDAL : IUserDAL
    {
      
        public UserDAL()
        {
        }

        public User FindById(int id)
        {
            var user = AppDbContext.Instance.Users
                       .Include(x => x.UserRoles)
                       .ThenInclude(y => y.UserolIdroleNavigation)
                       .Include(x => x.ImgStorages)
                       .Where(x => x.IdUser == id)
                       .AsNoTracking()
                       .SingleOrDefault();
            return user;
        }
        public List<User> FindByProperty(Dictionary<string, string> properties , string orderBy) 
        {
            var predicate = PredicateBuilder.True<User>();      
            if (properties.ContainsKey("code"))
            {
                predicate = predicate.And(x => x.UserCode.Equals(properties["code"]));
            }
            if (properties.ContainsKey("password"))
            {
                predicate = predicate.And(x => x.UserPassword.Equals(properties["password"]));
            }
            if (properties.ContainsKey("name"))
            {
                predicate = predicate.And(x => x.UserName.Contains(properties["name"]));
            }
            if (properties.ContainsKey("status"))
            {
                if (properties["status"] == "Active") predicate = predicate.And(x => x.UserActiveflag == true);
                else predicate = predicate.And(x => x.UserActiveflag == false);
            }
            IQueryable<User> query = AppDbContext.Instance.Users
                                      .Include(x => x.UserRoles)
                                      .ThenInclude(y => y.UserolIdroleNavigation)
                                      .Include(x => x.ImgStorages)
                                      .Where(predicate);
            switch (orderBy)
            {
                case "None": break;
                case "Name Asc": query = query.OrderBy(x => x.UserName); break;
                case "Name Desc": query = query.OrderByDescending(x => x.UserName); break;
                default: break;
            }
            List<User> result = query.AsNoTracking().ToList();
            return result;
        }

        public void AddUser(User user)
        {
            user.UserActiveflag = true;
            AppDbContext.Instance.Add(user);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(user).State = EntityState.Detached;
        }

        
        public void UpdateUser(User user)
        {
            user.UserActiveflag = true;
            AppDbContext.Instance.Update(user);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(user).State = EntityState.Detached;
        }
        public void DelUser(int idUser)
        {
            User user = AppDbContext.Instance.Users.Where(x =>x.IdUser ==idUser).SingleOrDefault();
            user.UserActiveflag = false;
            AppDbContext.Instance.Update(user);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(user).State = EntityState.Detached;
        }

        public void RestoreUser(int idUser)
        {
            User user = AppDbContext.Instance.Users.Where(x => x.IdUser == idUser).SingleOrDefault();
            user.UserActiveflag = true;
            AppDbContext.Instance.Update(user);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(user).State = EntityState.Detached;
        }

    

      
        public List<User> CheckExisted(Dictionary<string, string> properties)
        {
            var predicate = PredicateBuilder.True<User>();
            if (properties.ContainsKey("phone") && properties.ContainsKey("gmail"))
                predicate = predicate.And(x => x.UserPhone == properties["phone"] || x.UserGmail == properties["gmail"]);
            if (properties.ContainsKey("code") && properties["code"] != "")
            {
                predicate = predicate.And(x => x.UserCode != properties["code"]);
            }
            var result = AppDbContext.Instance.Users.Where(predicate).AsNoTracking().ToList();
            return result;
        }

        public int Getnextid()
        {
            int id;
            using (var command = AppDbContext.Instance.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT IDENT_CURRENT('user')+1";
                AppDbContext.Instance.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    result.Read();
                    id = Decimal.ToInt32((decimal)result[0]);
                }
            }
            return id;
        }
    }
}
