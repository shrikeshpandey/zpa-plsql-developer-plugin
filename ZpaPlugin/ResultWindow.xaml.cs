﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using ZpaPlugin.Models;
using ZpaPlugin.ViewModels;

namespace ZpaPlugin
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        private readonly ResultViewModel vm;

        public ResultWindow()
        {
            InitializeComponent();

            Closed += ResultWindow_Closed;

            vm = (ResultViewModel)DataContext;
        }

        public ResultWindow(List<Issue> issues) : this()
        {
            vm.Issues = new ObservableCollection<Issue>(issues);
        }

        private void ResultWindow_Closed(object sender, System.EventArgs e)
        {
            ZpaPlugin.ClearError();
        }
    }
}
