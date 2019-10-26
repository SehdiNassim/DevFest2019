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

namespace Scality
{
    /// <summary>
    /// Logique d'interaction pour Erreur.xaml
    /// </summary>
    public partial class Erreur : Window
    {
        public Erreur()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            this.Owner = App.Current.MainWindow;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
