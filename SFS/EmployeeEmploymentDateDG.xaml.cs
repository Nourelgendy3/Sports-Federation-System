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
using System.Windows.Shapes;

namespace SFS
{
    /// <summary>
    /// Interaction logic for EmployeeEmploymentDateDG.xaml
    /// </summary>
    public partial class EmployeeEmploymentDateDG : Window
    {
        public EmployeeEmploymentDateDG()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmploymentdurationQuery md = new EmploymentdurationQuery();
            md.Show();
            this.Close();
        }
    }
}
