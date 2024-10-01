using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Itenary_Project.ItenaryViewModel;

namespace Itenary_Project
{
    static class ItenaryConfig
    {
        public static Window FrmNewIternary { get; set; }

        public static Window FrmEditIternary { get; set; }
        //view model
        public static IternaryViewModel VueModel { get; set; }

        static ItenaryConfig()
        {
            VueModel = new IternaryViewModel();
            FrmNewIternary = new NewItenary();
            FrmEditIternary = new EditItenary();

        }
    }
}
