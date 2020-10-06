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
using Alfreelina_P1_AP1.Entidades;
using Alfreelina_P1_AP1.BLL;

namespace Alfreelina_P1_AP1.UI.Consultas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class cCiudades : Window
    {
        public cCiudades()
        {
          // InitializeComponent();
        }
    private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
         /*  Consultas.ItemsSource = null;
            var listado = new List<Ciudades>();


                listado = CiudadesBLL.GetList(c => true);
            Consultas.ItemsSource = listado;*/
        }
    }
}