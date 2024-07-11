using Microsoft.Win32;
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

namespace ArhivVideos.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void GetVideo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = "*.mov;*.mp4; | *.mov;*.mp4;" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                VideoControl.Source = new Uri(dialog.FileName);
                VideoControl.Play();
            }
        }

        private void RunVideo_Click(object sender, RoutedEventArgs e)
        {
            VideoControl.Play();
        }

        private void StopVideo_Click(object sender, RoutedEventArgs e)
        {
            VideoControl.Pause();
        }
    }
}
