using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Itenary_Project
{
    static class FormConfig
    {
        public static Window frmEdit { get; set; } = new EditItenary();
        public static Window frmNewItenary { get; set; } = new NewItenary();
    }
}
