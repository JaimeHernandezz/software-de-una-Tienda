﻿#pragma checksum "..\..\Registros.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C991560D18BFC53F1F2BBC7ECA42FF0DCFAB0B4D"
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
    /// Registros
    /// </summary>
    public partial class Registros : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUsuarioNuevo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUsuarioEditar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUsuarioGuardar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUsuarioCancelar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUsuarioEliminar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbClienteId;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbUsuario;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPasword;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPasword2;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Registros.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgUsuario;
        
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
            System.Uri resourceLocater = new System.Uri("/Tienda.GUI;component/registros.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registros.xaml"
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
            this.btnUsuarioNuevo = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Registros.xaml"
            this.btnUsuarioNuevo.Click += new System.Windows.RoutedEventHandler(this.btnUsuarioNuevo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnUsuarioEditar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Registros.xaml"
            this.btnUsuarioEditar.Click += new System.Windows.RoutedEventHandler(this.btnUsuarioEditar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnUsuarioGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Registros.xaml"
            this.btnUsuarioGuardar.Click += new System.Windows.RoutedEventHandler(this.btnUsuarioGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnUsuarioCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Registros.xaml"
            this.btnUsuarioCancelar.Click += new System.Windows.RoutedEventHandler(this.btnUsuarioCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUsuarioEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Registros.xaml"
            this.btnUsuarioEliminar.Click += new System.Windows.RoutedEventHandler(this.btnUsuarioEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txbClienteId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txbUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txbPasword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txbPasword2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.dtgUsuario = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

