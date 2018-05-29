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

namespace Ventas.GUI
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		

		private void btnEntrar_Click(object sender, RoutedEventArgs e)
		{
			if (txbUsuario.Text == "Jaime" && txbContraseña.Password == "199823")
			{
				Ventasss b = new Ventasss();
				b.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Usuario o Contraseña incorrectas", "Usuario", MessageBoxButton.OK, MessageBoxImage.Error);
					return;
			}

		}

		private void btnSalir_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
