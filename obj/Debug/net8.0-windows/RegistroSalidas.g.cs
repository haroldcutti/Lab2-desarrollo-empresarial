﻿#pragma checksum "..\..\..\RegistroSalidas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "317A6B8E4E8B2F2F8F45125DF7D4816827F8F0E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Lab2 {
    
    
    /// <summary>
    /// RegistroSalidas
    /// </summary>
    public partial class RegistroSalidas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TipoDocumentoComboBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumeroDocumentoTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PesoTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TipoAutoTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NombreTransportistaTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaPicker;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PesoIngresoTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\RegistroSalidas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PesoSalidaTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lab2;component/registrosalidas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RegistroSalidas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TipoDocumentoComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.NumeroDocumentoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PesoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TipoAutoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NombreTransportistaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.FechaPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.PesoIngresoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PesoSalidaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

