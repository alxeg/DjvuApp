﻿using System.Threading.Tasks;
using Windows.ApplicationModel.Email;
using Windows.Storage;
using Windows.System;
using DjvuApp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace DjvuApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        private NavigationHelper navigationHelper;

        public AboutPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var version = Package.Current.Id.Version;
            versionTextBlock.Text = String.Format("Version {0}.{1}.{2}.{3}\nBy Useless guy\nFrom Russia with love :)", version.Major, version.Minor, version.Build, version.Revision);
        }

        private async void ContactMeButtonClickHandler(object sender, RoutedEventArgs e)
        {
            var recipient = new EmailRecipient("djvureaderwp@gmail.com", "Djvu Reader developer");
            var message = new EmailMessage();
            message.To.Add(recipient);
            message.Subject = "DjVu Reader";
            await EmailManager.ShowComposeNewEmailAsync(message);
        }

        private async void ShowMyAppsButtonClickHandler(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("zune:search?publisher=Useless guy"));
        }

        private async void ShowPicoLyricsButtonClickHandler(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("zune:navigate?appid=75e3bd8f-3eee-df11-9264-00237de2db9e"));
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/PicoLyrics/1.png"));
            await Launcher.LaunchFileAsync(file);
        }

        private async void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/PicoLyrics/2.png"));
            await Launcher.LaunchFileAsync(file);
        }

        private async void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/PicoLyrics/3.png"));
            await Launcher.LaunchFileAsync(file);
        }

        private async void RateButtonClickHandler(object sender, RoutedEventArgs e)
        {
            await App.RateApp();
        }
    }
}
