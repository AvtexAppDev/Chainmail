﻿#pragma checksum "C:\Development\Chainmail\MatchIt\MatchIt\DetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5F1A287744D8F2D7B50EC6C82E88F50"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace MatchIt
{
    public partial class DetailPage : Windows.UI.Xaml.Controls.UserControl
    {
        Windows.UI.Xaml.Data.CollectionViewSource CollectionViewSource;
        Windows.UI.Xaml.Controls.Grid LayoutRoot;
        Windows.UI.Xaml.VisualStateGroup OrientationStates;
        Windows.UI.Xaml.VisualState Full;
        Windows.UI.Xaml.VisualState Fill;
        Windows.UI.Xaml.VisualState Portrait;
        Windows.UI.Xaml.VisualState Snapped;
        Windows.UI.Xaml.Controls.FlipView FlipView;
        Windows.UI.Xaml.Controls.ApplicationBar ApplicationBar;
        Windows.UI.Xaml.Controls.StackPanel NextPanel;
        Windows.UI.Xaml.Controls.Button NextButton;
        Windows.UI.Xaml.Controls.Button PreviousButton;
        Windows.UI.Xaml.Controls.Button HomeButton;
        Windows.UI.Xaml.Controls.Button BackButton;
        Windows.UI.Xaml.Controls.TextBlock PageTitle;
        private bool _contentLoaded;

        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-resource://matchit/Files/DetailPage.xaml"));

            CollectionViewSource = (Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("CollectionViewSource");
            LayoutRoot = (Windows.UI.Xaml.Controls.Grid)this.FindName("LayoutRoot");
            OrientationStates = (Windows.UI.Xaml.VisualStateGroup)this.FindName("OrientationStates");
            Full = (Windows.UI.Xaml.VisualState)this.FindName("Full");
            Fill = (Windows.UI.Xaml.VisualState)this.FindName("Fill");
            Portrait = (Windows.UI.Xaml.VisualState)this.FindName("Portrait");
            Snapped = (Windows.UI.Xaml.VisualState)this.FindName("Snapped");
            FlipView = (Windows.UI.Xaml.Controls.FlipView)this.FindName("FlipView");
            ApplicationBar = (Windows.UI.Xaml.Controls.ApplicationBar)this.FindName("ApplicationBar");
            NextPanel = (Windows.UI.Xaml.Controls.StackPanel)this.FindName("NextPanel");
            NextButton = (Windows.UI.Xaml.Controls.Button)this.FindName("NextButton");
            PreviousButton = (Windows.UI.Xaml.Controls.Button)this.FindName("PreviousButton");
            HomeButton = (Windows.UI.Xaml.Controls.Button)this.FindName("HomeButton");
            BackButton = (Windows.UI.Xaml.Controls.Button)this.FindName("BackButton");
            PageTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("PageTitle");
        }
    }
}

