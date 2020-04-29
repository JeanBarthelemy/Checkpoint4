using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Checkpoint4WPF
{
    /// <summary>
    /// Interaction logic for ArtistsWindow.xaml
    /// </summary>
    public partial class ArtistsWindow : Window
    {
        public ArtistsWindow(MainWindow owner)
        {
            InitializeComponent();
            this.Owner = owner;
        }
    }
}
