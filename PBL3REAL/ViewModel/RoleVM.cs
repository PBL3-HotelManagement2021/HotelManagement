using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    public class RoleVM
    {
        public RoleVM()
        {
            ActionList = new List<string>();
        }
        public int IdRole { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsSelected { get; set; }

        public List<string> ActionList;
    }
}
