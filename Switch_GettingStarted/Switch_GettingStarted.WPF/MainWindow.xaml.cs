﻿using Syncfusion.XForms.WPF.Buttons;
using System;
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
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;
namespace Switch_GettingStarted.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            Syncfusion.XForms.WPF.Buttons.SfButtonRenderer.Init();
            Syncfusion.XForms.WPF.Border.SfBorderRenderer.Init();
            LoadApplication(new Switch_GettingStarted.App());
        }
    }
}
