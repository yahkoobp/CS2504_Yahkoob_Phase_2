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

namespace FullNameProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FullNameWindow : Window
    {
        public FullNameWindow()
        {
            InitializeComponent();
            this.DataContext = FullNameConfig.VueModel;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            FullNameConfig.VueModel.EditablePerson.FirstName = FullNameConfig.VueModel.Person.FirstName;
            FullNameConfig.VueModel.EditablePerson.LastName = FullNameConfig.VueModel.Person.LastName;
            FullNameConfig.VueModel.EditablePerson = FullNameConfig.VueModel.EditablePerson;
            FullNameConfig.FrmEditFullName.Show();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown(); 
        }
    }
}
