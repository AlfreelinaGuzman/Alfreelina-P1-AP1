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

namespace Alfreelina_P1_AP1.UI.Registros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class rCiudades : Window
    {
        private Ciudades ciudades = new Ciudades();
        public rCiudades()
        {
            InitializeComponent();
            this.DataContext = ciudades;
        }

        private void Limpiar(){
            this.ciudades = new Ciudades();
            this.DataContext = ciudades;
        }

        private void BuscarButton_click(object sender, RoutedEventArgs e){
            var encontrado = CiudadesBLL.Buscar(Convert.ToInt32(CiudadIDTextBox.Text));
            if(encontrado!= null)
                ciudades = encontrado;
            else
            {
                Limpiar();
            }
            this.DataContext = ciudades;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e){
            var paso = CiudadesBLL.Guardar(ciudades);
            if (paso){
                MessageBox.Show("Guardado Correctamente!");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error 01: No se pudo guardar!");
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e){

            if(CiudadesBLL.Eliminar(Convert.ToInt32(CiudadIDTextBox.Text))){
                MessageBox.Show("Se elimino correctamente!");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error 02: No se pudo Eliminar");
            }
        }
    }
}