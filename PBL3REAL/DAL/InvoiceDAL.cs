
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace PBL3REAL.DAL
{
    public class InvoiceDAL
    {
        public static InvoiceDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new InvoiceDAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static InvoiceDAL _Instance;
        public InvoiceDAL()
        {
        }
        public List<Invoice> getAll()
        {
         
             var result = AppDbContext.Instance.Invoices
                          .Include(x =>x.InvIdbookNavigation)
                          .ThenInclude(y =>y.BookIdclientNavigation)
                          .AsNoTracking()  
                          .ToList();
            return result;
        }

        public Invoice findById(int idinvoice)
        {
            Invoice result = (from inv in AppDbContext.Instance.Invoices
                          join book in AppDbContext.Instance.Bookings on inv.InvIdbook equals book.IdBook
                          join client in AppDbContext.Instance.Clients on book.BookIdclient equals client.IdClient
                          join user in AppDbContext.Instance.Users on book.BookIdclient equals user.IdUser
                          where inv.IdInvoice == idinvoice
                          select new Invoice()
                          {
                              IdInvoice = inv.IdInvoice,
                              InvCreatedate = inv.InvCreatedate,
                              InvUpdatedate = inv.InvUpdatedate,
                              TotalPrice = inv.TotalPrice,                             
                              InvIdbookNavigation = new Booking
                              {
                                  IdBook = book.IdBook,
                                  BookCheckindate = book.BookCheckindate,
                                  BookCheckoutdate = book.BookCheckoutdate,
                                  BookIdclientNavigation = new Client()
                                  {
                                      IdClient = client.IdClient,
                                      CliCode = client.CliCode,
                                      CliName = client.CliName,
                                      CliPhone =client.CliPhone
                                  },
                              BookIduserNavigation = new User()
                              {
                                  IdUser = user.IdUser,
                                  UserCode = user.UserCode
                              }
                              }
                          }).SingleOrDefault();
            return result;
                            
        }

       

    }
}
