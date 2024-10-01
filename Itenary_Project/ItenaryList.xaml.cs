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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Itenary_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ItenaryList : Window
    {
        public ItenaryList()
        {
            InitializeComponent();
            this.DataContext = ItenaryConfig.VueModel;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btNew_Click(object sender, RoutedEventArgs e)
        {
            ItenaryConfig.FrmNewIternary.Show();
            NewItenary newIternaryWindow = (NewItenary)ItenaryConfig.FrmNewIternary;
            ItenaryConfig.VueModel.NewWindowClose = newIternaryWindow.WindowClose;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (grdItenary.SelectedIndex == -1)
            {
                var result = MessageBox.Show(messageBoxText: "Please select iternary to edit",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);
                return;
            }
            ItenaryConfig.FrmEditIternary.Show();
            EditItenary editIternaryWindow = (EditItenary)ItenaryConfig.FrmEditIternary;
            ItenaryConfig.VueModel.EditWindowClose = editIternaryWindow.WindowClose;
        }
    }
}

