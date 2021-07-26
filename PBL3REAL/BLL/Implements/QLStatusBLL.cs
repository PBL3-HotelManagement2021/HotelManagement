using System.Collections.Generic;
using AutoMapper;

using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;

namespace HotelManagement.BBL.Implement
{
    public class QLStatusBLL 
    {
        private StatusDAL _statusDAL;
      
        private Mapper mapper;
        public QLStatusBLL(){
            _statusDAL = new StatusDAL();
            mapper = new Mapper(MapperVM.config);
        }
        public List<StatusVM> getAll()
        {
            List<Status> list = _statusDAL.GetAll();
            List<StatusVM> listVm = new List<StatusVM>();
            foreach(Status status in list){
                StatusVM statusVM = mapper.Map<StatusVM>(status);
                listVm.Add(statusVM);
            }
            return listVm;
        }
    }
}