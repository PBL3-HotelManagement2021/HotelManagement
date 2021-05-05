using System.Collections.Generic;
using AutoMapper;

using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.Model;

namespace HotelManagement.BBL.Implement
{
    public class StatusBLL 
    {
        private StatusDAL _statusDAL;
        private MapperConfiguration config = new MapperConfiguration(cfg =>
        {
           
            cfg.CreateMap<Status, StatusVM>().ReverseMap();
        });
        private Mapper mapper;
        public StatusBLL(){
            _statusDAL = new StatusDAL();
            mapper = new Mapper(config);
        }
        public List<StatusVM> getAll()
        {
            List<Status> list = _statusDAL.getAll();
            List<StatusVM> listVm = new List<StatusVM>();
            foreach(Status status in list){
                StatusVM statusVM = mapper.Map<StatusVM>(status);
                listVm.Add(statusVM);
            }
            return listVm;
        }
    }
}