﻿using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PBL3REAL.DAL
{
    class ClientDAL
    {
        private AppDbContext _appDbContext;
        public ClientDAL()
        {
            _appDbContext = new AppDbContext();
        }

        public void add(Client client)
        {
            _appDbContext.Add(client);
            _appDbContext.SaveChanges();
        }

        public List<Client> getAll()
        {
            var list = (from emp in _appDbContext.Clients
                        select new
                        {
                            temp = emp
                        }).ToList();
            List<Client> clis = new List<Client>();
            foreach (var val in list)
            {
                clis.Add(val.temp);
            }
            return clis;
        }
    }
}