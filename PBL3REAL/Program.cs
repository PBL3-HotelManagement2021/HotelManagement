using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.View;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PBL3REAL
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var x = UserDAL.Instance.findById(0);
            Application.Run(new Form_Login());
           // Application.Run(new Form_View_Statistic_Analyze());
        }
    }
}
