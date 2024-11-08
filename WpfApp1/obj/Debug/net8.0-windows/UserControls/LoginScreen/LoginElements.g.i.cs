﻿#pragma checksum "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0EED0230812ED27FC9830015574BF15CAD718F4B"
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
using WpfApp1.UserControls.LoginScreen;


namespace WpfApp1.UserControls.LoginScreen {
    
    
    /// <summary>
    /// LoginElements
    /// </summary>
    public partial class LoginElements : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AccountNameLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameAccountBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AccountPasswordLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordAccountBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;V1.0.0.0;component/usercontrols/loginscreen/loginelements.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
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
            this.AccountNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.NameAccountBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AccountPasswordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.PasswordAccountBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
            this.PasswordAccountBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.OnEnter_Pressed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\UserControls\LoginScreen\LoginElements.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.OnLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

