﻿#pragma checksum "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705EB96212F0AC7B3914B8DDFCD7571C08693E92"
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
using WpfApp1.UserControls;


namespace WpfApp1.UserControls {
    
    
    /// <summary>
    /// CreateAccount
    /// </summary>
    public partial class CreateAccount : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CreateAccountGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NewAccountNameLabel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewNameAccountBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NewAccountPasswordLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewPasswordAccountBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateNewAccountButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/usercontrols/loginscreen/createaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CreateAccountGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.NewAccountNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.NewNameAccountBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NewAccountPasswordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.NewPasswordAccountBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CreateNewAccountButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\UserControls\LoginScreen\CreateAccount.xaml"
            this.CreateNewAccountButton.Click += new System.Windows.RoutedEventHandler(this.OnCreateAccount_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

