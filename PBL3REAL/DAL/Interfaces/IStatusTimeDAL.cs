using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IStatusTimeDAL
    {
        public void Add(List<StatusTime> listadd);
        public List<StatusTime> FindByIdRoom(int idroom);
        public void Delete(List<int> listdel);
        public void Update(List<StatusTime> listedit);



    }
}
