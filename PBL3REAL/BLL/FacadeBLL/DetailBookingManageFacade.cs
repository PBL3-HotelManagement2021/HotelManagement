using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.Extention;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.FacadeBLL
{
    public class DetailBookingManageFacade
    {
        private IBookingBLL _qlbookingBLLProvider;
        private IRoomTypeBLL _qlroomTypeBLLProvider;
        private IRoomBLL _qlroomBLLProvider;
        private IClientBLL _qlclientBLLProvider;
        public DetailBookingManageFacade()
        {
            _qlbookingBLLProvider = new QLBookingBLL();
            _qlroomTypeBLLProvider = new QLRoomTypeBLL();
            _qlroomBLLProvider = new QLRoomBLL();
            _qlclientBLLProvider = new QLClientBLL();
        }

        public List<CbbItem> AddComboboxRoomType()
        {
            return _qlroomTypeBLLProvider.AddCombobox();
        }
        public List<AvailableRoomVM> FindAvailableRoom(int idRoomtype, DateTime fromDate, DateTime toDate)
        {
            return _qlroomBLLProvider.FindAvailableRoom(idRoomtype, fromDate, toDate);
        }
        public BookingDetailVM GetDetail(int idBook)
        {
            return _qlbookingBLLProvider.GetDetail(idBook);
        }
        public RoomDetailVM FindRoomByID(int idRoom)
        {
            return _qlroomBLLProvider.FindByID(idRoom);
        }
        public void AddBooking(BookingDetailVM detailVM)
        {
            _qlbookingBLLProvider.AddBooking(detailVM);
        }
         public List<ClientVM> FindClient(int pages,int rows,Dictionary<string , string >properties , string orderBy)
        {
            return _qlclientBLLProvider.FindByProperty(pages, rows, properties, orderBy);
        }
        public void UpdateBooking(BookingDetailVM detailVM,List<int> listDel)
        {
            _qlbookingBLLProvider.UpdateBooking(detailVM, listDel);
        }
        public void CheckinBooking(int idBook)
        {
            _qlbookingBLLProvider.CheckinBooking(idBook);
        }
    }

}
