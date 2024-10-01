using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Itenary_Project
{
    /// <summary>
    /// Interaction logic for NewItenary.xaml
    /// </summary>
    public partial class NewItenary : Window
    {
        public NewItenary()
        {
            InitializeComponent();
            this.DataContext = ItenaryConfig.VueModel;
        }
        public void WindowClose()
        {
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
