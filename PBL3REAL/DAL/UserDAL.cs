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
        public List<User> getall()
        {
            List<User> result = AppDbContext.Instance.Users
                                .Include(x => x.UserRoles)
                                .ThenInclude(y =>y.UserolIdroleNavigation)
                                .Include(x =>x.ImgStorages)
                                .ToList();
            return result;
        }

        public void addUser(User user)
        {
            AppDbContext.Instance.Add(user);
            AppDbContext.Instance.SaveChanges();
        }
        public void delUser(int idUser)
        {
            User user = AppDbContext.Instance.Users.Find(idUser);
            AppDbContext.Instance.Remove(user);
            AppDbContext.Instance.SaveChanges();
        }

        public void addUserRole(List<UserRole> list)
        {
            AppDbContext.Instance.AddRange(list);
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
