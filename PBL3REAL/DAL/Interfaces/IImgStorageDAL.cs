using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IImgStorageDAL
    {
        public void Delete(List<int> listdel);
        public void Add(List<ImgStorage> listadd);
        public List<ImgStorage> FindByIDRoomtype(int id);

    }
}
