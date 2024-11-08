﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void OnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            bool _isHidden = CreateAccountGrid.Visibility == Visibility.Hidden;
            ShowCreateAccountPanel(_isHidden);
        }

        void ShowCreateAccountPanel(bool _show)
        {
            CreateAccountGrid.Visibility = _show ? Visibility.Visible : Visibility.Hidden;
        }

    }
}
