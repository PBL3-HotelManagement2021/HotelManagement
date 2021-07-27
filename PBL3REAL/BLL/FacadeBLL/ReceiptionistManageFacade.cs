using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.Extention;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.FacadeBLL
{
    public class ReceiptionistManageFacade
    {
        private IBookingBLL _qlbookingBLLProvider;
        private IInvoiceBLL _qLInvoiceBLLProvider;
        private IRoomBLL _qlroomBLLProvider;
        private IRoomTypeBLL _qlroomTypeBLLProvider;

        public ReceiptionistManageFacade()
        {
            _qlbookingBLLProvider = new QLBookingBLL();
            _qlroomBLLProvider = new QLRoomBLL();
            _qlroomTypeBLLProvider = new QLRoomTypeBLL();
            _qLInvoiceBLLProvider = new QLInvoiceBLL();
        }

        public List<BookingVM> FindBooking(int BookingCurrentPage, int ROWS, CalendarVM searchByDate, string bookingSearch, string bookOrderBy, string bookStatus)
        {
            return _qlbookingBLLProvider.FindByProperty(BookingCurrentPage, ROWS, searchByDate, bookingSearch, bookOrderBy, bookStatus);
        }
        public int GetBookingPagination(int ROWS, CalendarVM searchByDate, string bookingSearch, string bookStatus)
        {
            return _qlbookingBLLProvider.GetPagination(ROWS, searchByDate, bookingSearch, bookStatus);
        }
        public List<InvoiceVM> FindInvoice(int pages, int rows, string bookCode, string invCode, string orderBy, CalendarVM searchByDate)
        {
            return _qLInvoiceBLLProvider.FindByProperties(pages, rows, bookCode, invCode, orderBy, searchByDate);
        }
        public void DelBooking(int idBook, string status)
        {
            _qlbookingBLLProvider.DelBooking(idBook, status);
        }
        public List<CbbItem> AddCombobox()
        {
            return _qlroomTypeBLLProvider.AddCombobox();
        }
        public List<RoomVM> FindRoom(int RoomCurrentPage, int ROWS, int idRoomTypeSearch, string nameSearch, int roomActivate)
        {
            return _qlroomBLLProvider.FindByProperty(RoomCurrentPage, ROWS, idRoomTypeSearch, nameSearch, roomActivate);
        }
        public RoomDetailVM FindRoomById(int idRoom)
        {
            return _qlroomBLLProvider.FindByID(1);
        }
        public int GetRoomPagination(int  ROWS,int idRoomTypeSearch, string nameSearch,int roomActivate)
        {
            return _qlroomBLLProvider.GetPagination(ROWS, idRoomTypeSearch, nameSearch, roomActivate);
        }
        public void DeleteRoom(int idRoom)
        {
            _qlroomBLLProvider.DeleteRoom( idRoom);
        }
          public void  RestoreRoom(int idRoom)
        {
            _qlroomBLLProvider.RestoreRoom( idRoom);
        }
          public List<RoomTypeVM>  FindRoomType(string rotySearch,string  rotyOrderBy, string rotyStatus)
        {
            return _qlroomTypeBLLProvider.FindByProperty(rotySearch, rotyOrderBy, rotyStatus);
        }
        public void DeleteRoomType(int idRoomType)
        {
            _qlroomTypeBLLProvider.DeleteRoomType(idRoomType);
        }
        public void RestoreRoomType(int idRoomType)
        {
            _qlroomTypeBLLProvider.RestoreRoomType(idRoomType);
        }
    }
}
