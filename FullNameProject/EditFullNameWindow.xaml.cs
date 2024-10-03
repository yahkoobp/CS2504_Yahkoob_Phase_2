﻿using System;
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

namespace FullNameProject
{
    /// <summary>
    /// Interaction logic for EditFullNameWindow.xaml
    /// </summary>
    public partial class EditFullNameWindow : Window
    {
        public EditFullNameWindow()
        {
            InitializeComponent();
            this.DataContext = FullNameConfig.VueModel;
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
