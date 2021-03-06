﻿using PubSub;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace QBox.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            var v = Package.Current.Id.Version;
            ApplicationVersion.Text = "V" + string.Format("{0}.{1}.{2}.{3}", v.Major, v.Minor, v.Build, v.Revision);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.Publish("About");
        }

        private async void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {

            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://github.com/mohsens22/QBox"));
        }
    }
}
