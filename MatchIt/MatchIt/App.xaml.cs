using Expression.Blend.SampleData.SampleDataSource;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace MatchIt
{
    partial class App
    {
        // TODO: Create a data model appropriate for your problem domain to replace the sample data
        private static SampleDataSource _sampleData;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            ShowGroupedCollection();
            Window.Current.Activate();
        }

        public static void ShowGroupedCollection()
        {
            var page = new GroupedCollectionPage();
            if (_sampleData == null) _sampleData = new SampleDataSource(page.BaseUri);
            page.Groups = _sampleData.GroupedCollections;
            Window.Current.Content = page;
        }

        public static void ShowCollectionSummary(IEnumerable<object> collection)
        {
            var page = new CollectionSummaryPage();
            if (_sampleData == null) _sampleData = new SampleDataSource(page.BaseUri);
            page.Items = collection;
            page.Item = collection;
            Window.Current.Content = page;
        }

        public static void ShowDetail(IEnumerable<object> collection, object item)
        {
            var page = new DetailPage();
            if (_sampleData == null) _sampleData = new SampleDataSource(page.BaseUri);
            page.Items = collection;
            page.Item = item;
            Window.Current.Content = page;
        }
    }
}
