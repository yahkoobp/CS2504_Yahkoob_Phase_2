using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;


namespace EditorAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Microsoft.Win32.OpenFileDialog dlgOpen = new Microsoft.Win32.OpenFileDialog();
        private Microsoft.Win32.SaveFileDialog dlgSave = new Microsoft.Win32.SaveFileDialog();
        private FontDialog dlgFont = new FontDialog();
        private ColorDialog dlgColor = new ColorDialog();



        private void mnuRed_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Background = Brushes.Red;
            
        }

        private void mnuBlue_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Background = Brushes.Blue;
            
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalContentAlignment =System.Windows.HorizontalAlignment.Left;
            lblStatus.Text = "Left Aligned";
        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            lblStatus.Text = "Center Aligned";
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Right;
            lblStatus.Text = "Right Aligned";
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            var result = dlgOpen.ShowDialog();
                var filename = dlgOpen.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                //logic to open
                try
                {
                    fs = new FileStream(filename, FileMode.Open);
                    sr = new StreamReader(fs);
                    txtEditor.Text = sr.ReadToEnd();

                }
                catch (FileNotFoundException fe)
                {
                    System.Windows.Forms.MessageBox.Show($"{fe.Message}");
                }
                catch (IOException ioe)
                {
                System.Windows.Forms.MessageBox.Show($"{ioe.Message}");
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();

                }
        }

       

        private void btnFont_Click(object sender, RoutedEventArgs e)
        {
            var result = dlgFont.ShowDialog();
            System.Drawing.Font font = dlgFont.Font;
            txtEditor.FontFamily = new FontFamily(font.Name);
            txtEditor.FontSize = font.Size;
            txtEditor.FontWeight = font.Bold ? FontWeights.Bold : FontWeights.Regular;
            txtEditor.FontStyle = font.Italic ? FontStyles.Italic : FontStyles.Normal;


        }

        private void mnuMore_Click(object sender, RoutedEventArgs e)
        {
            var result = dlgColor.ShowDialog();
            var color = dlgColor.Color;
            txtEditor.Background = new SolidColorBrush(Color.FromArgb(color.A , color.R , color.G , color.B));

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            var result = dlgSave.ShowDialog();
                var filename = dlgSave.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                //logic to save
                try
                {
                    fs = new FileStream(filename, FileMode.Create);
                    sw = new StreamWriter(fs);
                    sw.Write(txtEditor.Text);

                }
                catch (FileNotFoundException fe)
                {
                    System.Windows.Forms.MessageBox.Show($"{fe.Message}");
                }
                catch (IOException ioe)
                {
                    System.Windows.Forms.MessageBox.Show($"{ioe.Message}");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();

                }
            }
    }
}
