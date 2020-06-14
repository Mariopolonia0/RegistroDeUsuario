using RegistroDeUsuario.BLL;
using RegistroDeUsuario.Entidades;
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

namespace EjercicioCambio
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
        Usuario usuario = new Usuario();
        private void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuarioTextBox.Text.Length == 0 |  IdTextBox.Text.Length == 0 | ContrasenaTextBox.Text.Length == 0 )
            {
                MessageBox.Show("Campo Imcompleto", "Mensaje De Error", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

           // usuario.IdUsuario = Convert.ToInt32(IdTextBox.Text);
            //usuario.nombreUsuario = UsuarioTextBox.Text;
           // usuario.contrasena = ContrasenaTextBox.Text;
            RegistroBLL.GuardarUsuario(usuario);
        }

        private void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            IdTextBox.Text = "";
            UsuarioTextBox.Text = "";
            ContrasenaTextBox.Text = "";
        }

        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            usuario = RegistroBLL.Buscar(id);
            UsuarioTextBox.Text = usuario.nombreUsuario;
            ContrasenaTextBox.Text = usuario.contrasena;
        }

        private void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
            ContrasenaTextBox.Text = usuario.nombreUsuario;
        }
    }
}
