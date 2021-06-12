using AutoMapper;
using HotelManagement.DAL.Implement;
using PBL3REAL.DAL;
using PBL3REAL.Extention;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    public class QLUserBLL
    {
        public static  UserVM stoUser;
        private UserDAL userDAL;
        private Mapper mapper;
        private ImgStorageDAL imgStorageDAL;
        public QLUserBLL()
        {
            mapper = new Mapper(MapperVM.config);
            userDAL = new UserDAL();
            imgStorageDAL = new ImgStorageDAL();
        }

        public List<UserVM> findByProperty(Dictionary<string , string >search , string orderBy)
        {
            List<UserVM> listVM = new List<UserVM>();
            foreach(User user in userDAL.findByProperty(search,orderBy))
            {
                UserVM userVM = mapper.Map<UserVM>(user);
                foreach(UserRole userRole in user.UserRoles)
                {
                    RoleVM roleVM = mapper.Map<RoleVM>(userRole.UserolIdroleNavigation);
                    userVM.ListRole.Add(roleVM);
                }
                foreach (ImgStorage img in user.ImgStorages)
                {
                    ImageVM imageVM = mapper.Map<ImageVM>(img);
                    userVM.ListImg.Add(imageVM);
                }
                listVM.Add(userVM);
            }
            return listVM;
        }

        public bool checkexisted(Dictionary<string, string> properties)
        {
            var list = userDAL.checkExisted(properties);
            if (list.Count == 0) return true;
            return false;
        }

        public UserVM findDetailUser(int id)
        {
            UserVM userVM = null;
            try
            {
                User user = userDAL.findById(id);
                userVM = mapper.Map<UserVM>(user);
                foreach (UserRole userRole in user.UserRoles)
                {
                    RoleVM roleVM = mapper.Map<RoleVM>(userRole.UserolIdroleNavigation);
                    userVM.ListRole.Add(roleVM);
                }
                foreach (ImgStorage img in user.ImgStorages)
                {
                    ImageVM imageVM = mapper.Map<ImageVM>(img);
                    userVM.ListImg.Add(imageVM);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return userVM;
        }

        public UserVM checkUser(Dictionary<string, string> properties)
        {
            UserVM userVM = null;
            try
            {
                properties["password"] = Md5.CreateMD5Hash(properties["password"]);
                List<User>list = userDAL.findByProperty(properties,"None");
                if(list.Count ==0) throw new ArgumentException("Access Denied");
                User user = list[0];
               userVM = mapper.Map<UserVM>(user);
                foreach (UserRole userRole in user.UserRoles)
                {
                    RoleVM roleVM = mapper.Map<RoleVM>(userRole.UserolIdroleNavigation);
                    userVM.ListRole.Add(roleVM);
                }
                foreach (ImgStorage img in user.ImgStorages)
                {
                    ImageVM imageVM = mapper.Map<ImageVM>(img);
                    userVM.ListImg.Add(imageVM);
                }
            }
            catch (Exception)
            {
                throw;
            }         
            return userVM;
        }

       
        public void delUser(int idUser)
        {
            try
            {
                userDAL.delUser(idUser);
                userDAL.delUserRole(idUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void restoreUser(int idUser)
        {
            try
            {
                userDAL.restoreUser(idUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void updateUser(UserVM userVM ,List<int>listdel , bool isPassChanged)
        {
            User user = new User();
            mapper.Map(userVM, user);
            if(isPassChanged) user.UserPassword = Md5.CreateMD5Hash(user.UserPassword);
            List<UserRole> ListRole = new List<UserRole>();
            List<ImgStorage> ListImg = new List<ImgStorage>();
            foreach (RoleVM roleVM in userVM.ListRole)
            {
                UserRole userRole = new UserRole
                {
                    UserolIduser = user.IdUser,
                    UserolIdrole = roleVM.IdRole
                };
                ListRole.Add(userRole);
            }
                foreach (ImageVM imageVM in userVM.ListImg)
                {
                    ImgStorage imgStorage = new ImgStorage();
                    mapper.Map(imageVM, imgStorage);
                    imgStorage.ImgstoIduser = user.IdUser;
                    if (imageVM.IdImgsto == 0) ListImg.Add(imgStorage);
                }
            try
            {
                userDAL.delUserRole(user.IdUser);
                userDAL.addUserRole(ListRole);
                if(listdel!=null) imgStorageDAL.delete(listdel);
                userDAL.updateUser(user);
                if(ListImg!=null) imgStorageDAL.add(ListImg);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void addUser(UserVM userVM)
        {
            int idUser = userDAL.getnextid();
            User user = new User();
            List<UserRole> ListRole = new List<UserRole>();
            List<ImgStorage> ListImg = new List<ImgStorage>();
            mapper.Map(userVM, user);
            user.UserPassword = Md5.CreateMD5Hash(user.UserPassword);
            foreach(RoleVM roleVM in userVM.ListRole)
            {
                UserRole userRole = new UserRole
                {
                    UserolIduser = idUser,
                    UserolIdrole = roleVM.IdRole
                };
               ListRole.Add(userRole);
            }
            foreach(ImageVM imgVM in userVM.ListImg)
            {
                ImgStorage imgStorage = new ImgStorage
                {
                    ImgstoIduser = idUser,
                    ImgstoUrl = imgVM.ImgstoUrl
                };
                ListImg.Add(imgStorage);
            }
            try
            {
              userDAL.addUser(user);
              userDAL.addUserRole(ListRole);
                imgStorageDAL.add(ListImg);      
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RoleVM> getRoleForUser()
        {
            List<RoleVM> listVM = new List<RoleVM>();
            foreach(Role role in RoleDAL.Instance.getAll())
            {
                RoleVM roleVM = mapper.Map<RoleVM>(role);
                listVM.Add(roleVM);
            }
            return listVM;
        }
    }
}
