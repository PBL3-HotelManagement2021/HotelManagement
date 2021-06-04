using HotelManagement.Extention;
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL
{
    public class UserDAL
    {
  
        public User findById(int id)
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
        public List<User> findByProperty(Dictionary<string, string> properties , string orderBy) 
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
            predicate = predicate.And(x => x.UserActiveflag == true);

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

        public void addUser(User user)
        {
            AppDbContext.Instance.Add(user);
            AppDbContext.Instance.SaveChanges();
        }

        
        public void updateUser(User user)
        {
            AppDbContext.Instance.Update(user);
            AppDbContext.Instance.SaveChanges();
        }
        public void delUser(int idUser)
        {
            User user = AppDbContext.Instance.Users.Where(x =>x.IdUser ==idUser).SingleOrDefault();
            user.UserActiveflag = false;
            AppDbContext.Instance.Update(user);
            AppDbContext.Instance.SaveChanges();
        }

        public void addUserRole(List<UserRole> list)
        {
            AppDbContext.Instance.AddRange(list);
            AppDbContext.Instance.SaveChanges();
        }

        public void delUserRole(int idUser)
        {
            var listdel = AppDbContext.Instance.UserRoles.Where(x => x.UserolIduser == idUser).ToList();
            AppDbContext.Instance.RemoveRange(listdel);
            AppDbContext.Instance.SaveChanges();
        }

        public int getnextid()
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
