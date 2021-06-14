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
        private Mapper mapper;
        public QLUserBLL()
        {
            mapper = new Mapper(MapperVM.config);
        }

        public List<UserVM> findByProperty(Dictionary<string , string >search , string orderBy)
        {
            List<UserVM> listVM = new List<UserVM>();
            foreach(User user in UserDAL.Instance.findByProperty(search,orderBy))
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
            var list = UserDAL.Instance.checkExisted(properties);
            if (list.Count == 0) return true;
            return false;
        }

        public UserVM findDetailUser(int id)
        {
            UserVM userVM = null;
            try
            {
                User user = UserDAL.Instance.findById(id);
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
            QLUserBLL.stoUser = null;
            try
            {
                properties["password"] = Md5.CreateMD5Hash(properties["password"]);
                List<User>list = UserDAL.Instance.findByProperty(properties,"None");
                if(list.Count ==0) throw new ArgumentException("Access Denied");
                User user = list[0];
                QLUserBLL.stoUser = mapper.Map<UserVM>(user);
                foreach (UserRole userRole in user.UserRoles)
                {
                    RoleVM roleVM = mapper.Map<RoleVM>(userRole.UserolIdroleNavigation);
                    QLUserBLL.stoUser.ListRole.Add(roleVM);
                }
                foreach (ImgStorage img in user.ImgStorages)
                {
                    ImageVM imageVM = mapper.Map<ImageVM>(img);
                    QLUserBLL.stoUser.ListImg.Add(imageVM);
                }
            }
            catch (Exception)
            {
                throw;
            }         
            return QLUserBLL.stoUser;
        }

       
        public void delUser(int idUser)
        {
            try
            {
                UserDAL.Instance.delUser(idUser);
                UserDAL.Instance.delUserRole(idUser);
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
                UserDAL.Instance.restoreUser(idUser);
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
                UserDAL.Instance.delUserRole(user.IdUser);
                UserDAL.Instance.addUserRole(ListRole);
                if(listdel!=null) ImgStorageDAL.Instance.delete(listdel);
                UserDAL.Instance.updateUser(user);
                if(ListImg!=null) ImgStorageDAL.Instance.add(ListImg);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void addUser(UserVM userVM)
        {
            int idUser = UserDAL.Instance.getnextid();
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
                UserDAL.Instance.addUser(user);
                UserDAL.Instance.addUserRole(ListRole);
                ImgStorageDAL.Instance.add(ListImg);      
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
