﻿using System;
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

namespace MasterPol.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainList.xaml
    /// </summary>
    public partial class MainLi : Page
    {
        public MainLi()
        {
            InitializeComponent();
            PartnetList.ItemsSource = Data.MasterPolEntities.GetContext().Partners.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.MainFrame.Navigate(new Pages.Hist());
        }
    }
}
