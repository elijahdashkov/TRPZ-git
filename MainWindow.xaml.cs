﻿using System.Windows;

namespace TRPZ2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lb1.Items.Add("Oleksiy Okorokov");
            lb1.Items.Add("Dmitrii Nieliepin");
            lb1.Items.Add("Max Vavryniuk");
			lb1.Items.Add("Andrey Kolomets");
        }
    }
}
