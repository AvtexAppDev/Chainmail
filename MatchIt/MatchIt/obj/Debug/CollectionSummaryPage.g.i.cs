﻿#pragma checksum "C:\Development\Chainmail\MatchIt\MatchIt\CollectionSummaryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F14ECEB60C04EA2B52D36B3190B3027"
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
    public partial class CollectionSummaryPage : Windows.UI.Xaml.Controls.UserControl
    {
        Windows.UI.Xaml.Data.CollectionViewSource CollectionViewSource;
        Windows.UI.Xaml.Controls.Grid LayoutRoot;
        Windows.UI.Xaml.VisualStateGroup OrientationStates;
        Windows.UI.Xaml.VisualState Full;
        Windows.UI.Xaml.VisualState Fill;
        Windows.UI.Xaml.VisualState Portrait;
        Windows.UI.Xaml.VisualState Snapped;
        Windows.UI.Xaml.Controls.ScrollViewer ScrollViewer;
        Windows.UI.Xaml.Controls.StackPanel CategoryPanel;
        Windows.UI.Xaml.Controls.Grid HeaderTitlePanel;
        Windows.UI.Xaml.Controls.GridView ItemGridView;
        Windows.UI.Xaml.Controls.ListView ItemListView;
        Windows.UI.Xaml.Controls.TextBlock Title;
        Windows.UI.Xaml.Controls.Image Image;
        Windows.UI.Xaml.Controls.TextBlock DescriptionText;
        Windows.UI.Xaml.Controls.Button BackButton;
        Windows.UI.Xaml.Controls.TextBlock PageTitle;
        private bool _contentLoaded;

        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-resource://matchit/Files/CollectionSummaryPage.xaml"));

            CollectionViewSource = (Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("CollectionViewSource");
            LayoutRoot = (Windows.UI.Xaml.Controls.Grid)this.FindName("LayoutRoot");
            OrientationStates = (Windows.UI.Xaml.VisualStateGroup)this.FindName("OrientationStates");
            Full = (Windows.UI.Xaml.VisualState)this.FindName("Full");
            Fill = (Windows.UI.Xaml.VisualState)this.FindName("Fill");
            Portrait = (Windows.UI.Xaml.VisualState)this.FindName("Portrait");
            Snapped = (Windows.UI.Xaml.VisualState)this.FindName("Snapped");
            ScrollViewer = (Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("ScrollViewer");
            CategoryPanel = (Windows.UI.Xaml.Controls.StackPanel)this.FindName("CategoryPanel");
            HeaderTitlePanel = (Windows.UI.Xaml.Controls.Grid)this.FindName("HeaderTitlePanel");
            ItemGridView = (Windows.UI.Xaml.Controls.GridView)this.FindName("ItemGridView");
            ItemListView = (Windows.UI.Xaml.Controls.ListView)this.FindName("ItemListView");
            Title = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("Title");
            Image = (Windows.UI.Xaml.Controls.Image)this.FindName("Image");
            DescriptionText = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("DescriptionText");
            BackButton = (Windows.UI.Xaml.Controls.Button)this.FindName("BackButton");
            PageTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("PageTitle");
        }
    }
}


