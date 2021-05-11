﻿using AutoMapper;
using HotelManagement.DAL.Implement;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    public class UserBLL
    {
        private UserDAL userDAL;
        private Mapper mapper;
        private ImgStorageDAL imgStorageDAL;
        public UserBLL()
        {
            mapper = new Mapper(MapperVM.config);
            userDAL = new UserDAL();
            imgStorageDAL = new ImgStorageDAL();
        }

        public List<UserVM> getAll()
        {
            List<UserVM> listVM = new List<UserVM>();
            foreach(User user in userDAL.getall())
            {
                UserVM userVM = mapper.Map<UserVM>(user);
                foreach(UserRole userRole in user.UserRoles)
                {
                    RoleVM roleVM = mapper.Map<RoleVM>(userRole.UserolIdroleNavigation);
                    userVM.ListRole.Add(roleVM);
                }
              
                listVM.Add(userVM);
            }
            return listVM;
        }


        public UserVM checkUser(string code , string password)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("code", code);
            properties.Add("password",password);
            UserVM userVM = null;
            try
            {
                User user = userDAL.findByProperty(properties)[0];
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
            foreach(RoleVM roleVM in userVM.ListRole)
            {
                UserRole userRole = new UserRole
                {
                    UserolIduser = idUser,
                    UserolActiveflag = true,
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
    }
}