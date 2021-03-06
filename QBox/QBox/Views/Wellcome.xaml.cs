﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
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
    public sealed partial class Wellcome : Page
    {
        public static Wellcome current;
        public Wellcome()
        {
            this.InitializeComponent();
            Logger.Navigate(typeof(SignIn));
            current = this;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Myer((SolidColorBrush)Application.Current.Resources["AppSuspressBrush"], new SolidColorBrush(Colors.White));
        }

        private async void Myer(SolidColorBrush Brush, SolidColorBrush Foreground)
        {
            SolidColorBrush a = Brush;
            try
            {
                ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
                titleBar.BackgroundColor = a.Color;

                titleBar.ButtonBackgroundColor = a.Color;

                titleBar.InactiveBackgroundColor = a.Color;
                titleBar.ButtonInactiveBackgroundColor = a.Color;
                titleBar.InactiveForegroundColor = Foreground.Color;
                titleBar.ButtonInactiveForegroundColor = Foreground.Color;
                titleBar.ForegroundColor = Foreground.Color;
                titleBar.ButtonForegroundColor = Foreground.Color;


                //fuck you asshilism

            }
            catch
            {

            }
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();
                if (statusBar != null)
                {
                    statusBar.BackgroundOpacity = 1;
                    statusBar.BackgroundColor = a.Color;
                    statusBar.ForegroundColor = Foreground.Color;
                }
            }
        }

        #region FlipView
        private void flipwel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (flipwel.SelectedIndex == 0)
            {
                m1();
            }
            if (flipwel.SelectedIndex == 1)
            {
                m2();
            }
            if (flipwel.SelectedIndex == 2)
            {
                m3();
            }
            if (flipwel.SelectedIndex == 3)
            {
                m4();
            }

        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            m1();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            m2();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            m3();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            m4();
        }

        private void m1()
        {
            b1.Opacity = 1;
            b2.Opacity = 0.5;
            b3.Opacity = 0.5;
            b4.Opacity = 0.5;
            flipwel.SelectedIndex = 0;
        }
        private void m2()
        {
            b1.Opacity = 0.5;
            b2.Opacity = 1;
            b3.Opacity = 0.5;
            b4.Opacity = 0.5;
            flipwel.SelectedIndex = 1;
        }
        private void m3()
        {
            b1.Opacity = 0.5;
            b2.Opacity = 0.5;
            b3.Opacity = 1;
            b4.Opacity = 0.5;
            flipwel.SelectedIndex = 2;
        }
        private void m4()
        {
            b1.Opacity = 0.5;
            b2.Opacity = 0.5;
            b3.Opacity = 0.5;
            b4.Opacity = 1;
            flipwel.SelectedIndex = 3;
        }



        #endregion

    }
}
