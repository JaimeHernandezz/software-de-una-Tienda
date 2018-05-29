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
using Tienda.BIZ;
using Tienda.COMMON.Entidades;
using Tienda.COMMON.Interfaces;
using Tienda.DAL;

namespace Ventas.GUI
{
	/// <summary>
	/// Lógica de interacción para Ventasss.xaml
	/// </summary>
	public partial class Ventasss : Window
	{

		enum accion
		{
			Nuevo,
			Editar
		}
		List<Ventaas> ventas;

		IManejadorTickets manejadorTickets;
		IManejadorClientes manejadorClientes;
		IManejadorProducto manejadorProducto;
		IManejadorEmpleados manejadorEmpleados;

		//accion accionClientes;
		//accion accionProductos;
		//accion accionEmpleados;

		public Ventasss()
		{
			InitializeComponent();

			manejadorTickets = new ManejadorTickets(new RepositorioTickets());
			manejadorClientes = new ManejadorClientes(new RepoitorioDeClientes());
			manejadorProducto = new ManejadoProductos(new RepositorioDeProductos());
			manejadorEmpleados = new ManejadorEmpleados(new RepositorioDeEmpleados());

			

			ventas = new List<Ventaas>();

			BotonesVentasEdicion(false);
			CargarTablas();

			HabilitarCamposDeVenta(false);

			TablaEnInventario();
			HabilitarCamposAlmacen(false);
		}

		private void HabilitarCamposAlmacen(bool v)
		{
			dtgTablaObservar.IsEnabled = v;
			txtTotalA.IsEnabled = v;
			txtClienteA.IsEnabled = v;
			txtEmpleadoA.IsEnabled = v;
			txtFechaA.IsEnabled = v;
			txtFolioA.IsEnabled = v;
			TablaEnInventario();
		}

		private void TablaEnInventario()
		{
			dtgAlmacen.ItemsSource = null;
			dtgAlmacen.ItemsSource = manejadorTickets.Listar;
		}

		private void HabilitarCamposDeVenta(bool v)
		{
			txtCantidadV.IsEnabled = v;
			cmbClienteV.IsEnabled = v;
			cmbEmpleadoV.IsEnabled = v;
		}

		private void CargarTablas()
		{
			txtFecha.Text = DateTime.Now.ToString();
			dtgVentaAlmacen.ItemsSource = null;
			dtgVentaAlmacen.ItemsSource = manejadorProducto.Listar;
			cmbClienteV.ItemsSource = null;
			cmbClienteV.ItemsSource = manejadorClientes.Listar;
			cmbEmpleadoV.ItemsSource = null;
			cmbEmpleadoV.ItemsSource = manejadorEmpleados.Listar;
			dtgVentas.ItemsSource = null;
			dtgVentas.ItemsSource = ventas;
		}

		private void BotonesVentasEdicion(bool value)
		{
			btnAgregarVenta.IsEnabled = value;
			btnVEntaVenta.IsEnabled = value;
			btnNuevaVenta.IsEnabled = !value;
			btnEliminarVenta.IsEnabled = value;
			btnCancelarVenta.IsEnabled = value;
		}



		private void LimpiarCamposVenta()
		{
			dtgVentas.ItemsSource = null;
			ventas = new List<Ventaas>();
			CargarTablas();
			txtCantidadV.Clear();
			cmbClienteV.Text = " ";
			cmbEmpleadoV.Text = " ";
			txtFechaA.Clear();
		}


		private void LimpiarAlmacen()
		{

			dtgTablaObservar.ItemsSource = null;
			txtTotalA.Clear();
			txtClienteA.Clear();
			txtEmpleadoA.Clear();
			txtFechaA.Clear();
			txtFolioA.Clear();
			TablaEnInventario();

		}

		private void btnAgregarVenta_Click(object sender, RoutedEventArgs e)
		{
			Productoss c = dtgVentaAlmacen.SelectedItem as Productoss;
			Ventaas a = new Ventaas();
			if (c != null)
			{
				if (string.IsNullOrEmpty(txtCantidadV.Text))
				{
					MessageBox.Show("No ha llenado el Campo de cantidad", "Farmacia", MessageBoxButton.OK, MessageBoxImage.Error);
					return;
				}
				foreach (var item in txtCantidadV.Text)
				{
					if (!(char.IsNumber(item)))
					{
						MessageBox.Show("Valor invalido, intente de nuevo (Solo números)", "Ventas", MessageBoxButton.OK, MessageBoxImage.Error);
						return;
					}
				}
				a.CantidadVentas = int.Parse(txtCantidadV.Text);
				a.CategoriaVentas = c.Categoria;
				a.DescripcionVentas = c.Descripcion;
				a.PrecioVentas = float.Parse(c.PrecioVenta);
				a.ProductosVentas = c.Nombre;
				a.TotalVentas = a.CantidadVentas * a.PrecioVentas;
				ventas.Add(a);
				dtgVentas.ItemsSource = null;
				dtgVentas.ItemsSource = ventas;
				txtCantidadV.Clear();
			}
			else
			{
				MessageBox.Show("No selecciono nada en la tabla", "Farmacia", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
		}

		private void btnVEntaVenta_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(cmbClienteV.Text) || string.IsNullOrEmpty(cmbEmpleadoV.Text))
			{
				MessageBox.Show("No ha llenado los datos del Empleado o Cliente ");
				return;
			}
			BotonesVentasEdicion(false);
			if (ventas.Count <= 0)
			{
				MessageBox.Show("No cuenta con ningun producto en venta", "Farmacia", MessageBoxButton.OK, MessageBoxImage.Information);
				return;
			}

			float Totalito = 0;
			foreach (Ventaas item in ventas)
			{
				Totalito += item.TotalVentas;
			}
			float IVa = 0.16f;
			float IvaIncluido = IVa * Totalito;
			float TotalVenta = IvaIncluido + Totalito;

			Ticket reporte = new Ticket(txtFechaA.Text + ".but");
			string datos = "", elementos = "", informacion = "";
			datos = string.Format("Farmacia \nFolio {0}\nFecha: {1}\nEmpleado: {2}\nCliente: {3}\n\nProducto   Precio Cantidad Total\n-------------------------------------\n", txtFecha.Text, txtFecha.Text, cmbEmpleadoV.Text.ToUpper(), cmbClienteV.Text.ToUpper());
			foreach (Ventaas item in ventas)
			{
				elementos += string.Format("{0}      {1}     {2}     {3}\n", item.ProductosVentas, item.PrecioVentas, item.CantidadVentas, item.TotalVentas);
			}
			informacion = string.Format("\nSubtotal: ${0}\nIva: ${1}\nTotal: ${2}\n\n   ¡¡¡Vuelva pronto!!!", Totalito.ToString(), IvaIncluido.ToString(), TotalVenta.ToString());
			reporte.Guardar(datos + elementos + informacion);
			MessageBox.Show("Subtotal: " + Totalito.ToString() + " \nIva " + (IvaIncluido).ToString() + " \nTotal " + TotalVenta.ToString() + "\nReporte Guardado con Exito: " + txtFecha.Text + ".poo", "Total de la Venta", MessageBoxButton.OK, MessageBoxImage.Information);
			try
			{
				Iventas Ventas = new Iventas()
				{
					Ncliente = cmbClienteV.Text,

					Fecha = txtFecha.Text,
					IvaPago = float.Parse(IvaIncluido.ToString()),
					Nempleado = cmbEmpleadoV.Text,
					TotalPago = float.Parse(Totalito.ToString()),
					StotalPago = TotalVenta,
					//ProductoVentas = ventas,

				};
				manejadorTickets.Agregar(Ventas);
				TablaEnInventario();
			}
			catch (Exception)
			{
				MessageBox.Show("No se pudo generar la lista de Inventario de Ventas", "Ventas", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			HabilitarCamposDeVenta(false);
			LimpiarCamposVenta();
		}

		private void btnNuevaVenta_Click(object sender, RoutedEventArgs e)
		{
			BotonesVentasEdicion(true);
			LimpiarCamposVenta();
			HabilitarCamposDeVenta(true);
			Random a = new Random();

			//txtFechaA.Text = txtFechaA.ToString();
		}

		private void btnEliminarVenta_Click(object sender, RoutedEventArgs e)
		{
			Ventaas c = dtgVentas.SelectedItem as Ventaas;
			if (c != null)
			{
				ventas.Remove(c);
				CargarTablas();
			}
			else
			{
				MessageBox.Show("No selecciono nada en la tabla en Venta", "Farmacia", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
		}

		private void btnCancelarVenta_Click(object sender, RoutedEventArgs e)
		{
			if (MessageBox.Show("Realmente esta seguro de cancelar la venta", "Farmacia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
			{
				BotonesVentasEdicion(false);
				HabilitarCamposDeVenta(false);
				dtgVentas.ItemsSource = null;
				ventas = new List<Ventaas>();
				txtFecha.Clear();
			}
		}







		private void dtgAlmacen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Iventas a = dtgAlmacen.SelectedItem as Iventas;
			if (a != null)
			{
				HabilitarCamposAlmacen(true);
				txtFolioA.Text = a.Id;
				txtFechaA.Text = a.Fecha;
				txtEmpleadoA.Text = a.Nempleado;
				dtgTablaObservar.ItemsSource = null;
				//dtgTablaObservar.ItemsSource = a.ProductoVentas;
				txtClienteA.Text = a.Ncliente;
				txtTotalA.Text = a.TotalPago.ToString();

			}
			else
			{
				MessageBox.Show("No se pudo seleccionar la fila, intente de nuevo", "Farmacia", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
		}

		private void btnLimpiarA_Click(object sender, RoutedEventArgs e)
		{
			LimpiarAlmacen();
		}

		private void btnEliminarA_Click(object sender, RoutedEventArgs e)
		{
			Iventas a = dtgAlmacen.SelectedItem as Iventas;
			if (a != null)
			{
				if (MessageBox.Show("Realmente desea eliminar el campo", "Farmacia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
				{
					manejadorTickets.Eliminar(a.Id);
					TablaEnInventario();
					LimpiarAlmacen();
				}
			}
			else
			{
				MessageBox.Show("No se pudo seleccionar la fila, intente de nuevo", "Farmacia", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
		}

		private void dtgTablaObservar_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void txtFechaA_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		
	}
}
