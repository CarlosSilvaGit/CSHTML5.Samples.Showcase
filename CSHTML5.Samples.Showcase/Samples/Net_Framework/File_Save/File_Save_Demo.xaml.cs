﻿using CSHTML5.Extensions.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CSHTML5.Samples.Showcase
{
    public partial class File_Save_Demo : UserControl
    {
        public File_Save_Demo()
        {
            this.InitializeComponent();
        }

        async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            await FileSaver.SaveTextToFile("MyTestFile.txt", "Hello World");
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "File_Save_Demo.xaml",
                    FilePathOnGitHub = "github/cshtml5/CSHTML5.Samples.Showcase/blob/master/CSHTML5.Samples.Showcase/Samples/Net_Framework/File_Save/File_Save_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "File_Save_Demo.xaml.cs",
                    FilePathOnGitHub = "github/cshtml5/CSHTML5.Samples.Showcase/blob/master/CSHTML5.Samples.Showcase/Samples/Net_Framework/File_Save/File_Save_Demo.xaml.cs"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "FileSaver.cs",
                    FilePathOnGitHub = "github/cshtml5/CSHTML5.Samples.Showcase/blob/master/CSHTML5.Samples.Showcase/Samples/Net_Framework/File_Save/FileSaver.cs"
                }
            });
        }

    }
}
