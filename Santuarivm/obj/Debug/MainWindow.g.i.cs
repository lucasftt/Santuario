﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "55038E2A4AB5250ED476B0D9041ADAC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Santuarivm;
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


namespace Santuarivm {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCadastrar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblConsulta;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblListas;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSobre;
        
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
            System.Uri resourceLocater = new System.Uri("/Santuarivm;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((Santuarivm.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 8 "..\..\MainWindow.xaml"
            ((Santuarivm.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblCadastrar = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.lblCadastrar.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lblCadastrar_MouseEnter);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.lblCadastrar.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lblCadastrar_MouseLeave);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.lblCadastrar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lblCadastrar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblConsulta = ((System.Windows.Controls.Label)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.lblConsulta.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lblConsulta_MouseEnter);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.lblConsulta.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lblConsulta_MouseLeave);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.lblConsulta.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lblConsulta_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblListas = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.lblListas.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lblListas_MouseEnter);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.lblListas.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lblListas_MouseLeave);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.lblListas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lblListas_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblSobre = ((System.Windows.Controls.Label)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.lblSobre.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lblSobre_MouseEnter);
            
            #line default
            #line hidden
            
            #line 27 "..\..\MainWindow.xaml"
            this.lblSobre.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lblSobre_MouseLeave);
            
            #line default
            #line hidden
            
            #line 27 "..\..\MainWindow.xaml"
            this.lblSobre.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lblSobre_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
