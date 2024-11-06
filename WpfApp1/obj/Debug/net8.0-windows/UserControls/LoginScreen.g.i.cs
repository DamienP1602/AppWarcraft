﻿#pragma checksum "..\..\..\..\UserControls\LoginScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3BADBC33E93179BA37DA7423D3ABF4CE0FAC4D6D"
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
using WpfApp1;
using WpfApp1.UserControls;


namespace WpfApp1 {
    
    
    /// <summary>
    /// LoginScreen
    /// </summary>
    public partial class LoginScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateAccountButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AccountNameLabel;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameAccountBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AccountPasswordLabel;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordAccountBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitButton;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\UserControls\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp1.UserControls.CreateAccount CreateAccountGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;V1.0.0.0;component/usercontrols/loginscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\LoginScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.CreateAccountButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\UserControls\LoginScreen.xaml"
            this.CreateAccountButton.Click += new System.Windows.RoutedEventHandler(this.OnCreateAccount_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AccountNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.NameAccountBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AccountPasswordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.PasswordAccountBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\UserControls\LoginScreen.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.OnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.QuitButton = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\UserControls\LoginScreen.xaml"
            this.QuitButton.Click += new System.Windows.RoutedEventHandler(this.OnExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreateAccountGrid = ((WpfApp1.UserControls.CreateAccount)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
