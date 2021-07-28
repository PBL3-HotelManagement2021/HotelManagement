using HotelManagement.DAL.Implement;
using PBL3REAL.DAL.Implements;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Facade
{
    public class  UserDALManageFacade
    {
        private IUserDAL _userDALProvider;
        private IImgStorageDAL _imageDALProvider;
        private IUserRoleDAL _userroleDALProvider;
        private IRoleDAL _roleDALProvider;

        public UserDALManageFacade()
        {
            _userDALProvider = new UserDAL();
            _imageDALProvider = new ImgStorageDAL();
            _userroleDALProvider = new UserRoleDAL();
            _roleDALProvider = new RoleDAL();
        }

        public User FindUserById(int id)
        {
            return _userDALProvider.FindById(id); 
        }
        public List<User> FindUser(Dictionary<string, string> properties, string orderBy)
        {
            return _userDALProvider.FindByProperty(properties, orderBy);
        }
        public void AddUser(User user)
        {
            _userDALProvider.Add(user);
        }
        public void UpdateUser(User user)
        {
            _userDALProvider.Update(user);
        }
        public void DelUser(int idUser)
        {
            _userDALProvider.Delete(idUser);
        }
        public void RestoreUser(int idUser)
        {
            _userDALProvider.Restore(idUser);
        }
        public void AddUserRole(List<UserRole> list)
        {
            _userroleDALProvider.AddUserRole(list);
        }
        public void DelUserRole(int idUser)
        {
            _userroleDALProvider.DelUserRole(idUser);
        }
        public List<User> CheckExisted(Dictionary<string, string> properties)
        {
            return _userDALProvider.CheckExisted(properties);
        }
        public int GetnextUserid()
        {
            return _userDALProvider.GetNextId();
        }
        public void DeleteImage(List<int> listdel)
        {
            _imageDALProvider.Delete(listdel);
        }
        public void AddImage(List<ImgStorage> listadd)
        {
            _imageDALProvider.Add(listadd);
        }


        public List<Role> GetAllRole()
        {
            return _roleDALProvider.GetAll();
        }
        public Role GetRoleDetail(int idRole)
        {
            return _roleDALProvider.FindById(idRole);
        }

    }
}
