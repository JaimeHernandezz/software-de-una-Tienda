﻿#pragma checksum "..\..\Empleados.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76EA730CCBE76215E0855A7D6BEC7955AEE69E7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tienda.GUI;


namespace Tienda.GUI {
    
    
    /// <summary>
    /// Empleados
    /// </summary>
    public partial class Empleados : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpleadoNuevo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpleadoEditar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpleadoGuardar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpleadoCancelar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpleadoEliminar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbEmpleadoId;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbEmpleadoNombre;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbEmpleadoApellido;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbEmpleadoDireccion;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbEmpleadoTelefono;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbEmpleadoMatricula;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgEmpleado;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tienda.GUI;component/empleados.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Empleados.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnEmpleadoNuevo = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Empleados.xaml"
            this.btnEmpleadoNuevo.Click += new System.Windows.RoutedEventHandler(this.btnEmpleadoNuevo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEmpleadoEditar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Empleados.xaml"
            this.btnEmpleadoEditar.Click += new System.Windows.RoutedEventHandler(this.btnEmpleadoEditar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnEmpleadoGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Empleados.xaml"
            this.btnEmpleadoGuardar.Click += new System.Windows.RoutedEventHandler(this.btnEmpleadoGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEmpleadoCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Empleados.xaml"
            this.btnEmpleadoCancelar.Click += new System.Windows.RoutedEventHandler(this.btnEmpleadoCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEmpleadoEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Empleados.xaml"
            this.btnEmpleadoEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEmpleadoEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txbEmpleadoId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txbEmpleadoNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txbEmpleadoApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txbEmpleadoDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txbEmpleadoTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txbEmpleadoMatricula = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.dtgEmpleado = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
