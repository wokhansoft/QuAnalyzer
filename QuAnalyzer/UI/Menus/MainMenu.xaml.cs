﻿using Microsoft.Win32;
using QuAnalyzer.UI.Pages;
using QuAnalyzer.UI.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Wokhan.Collections.Generic.Extensions;
using Wokhan.Data.Providers.Contracts;

namespace QuAnalyzer.UI.Menus
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        
        //public string ApplicationName { get; } = "QuAnalyzer v" + Assembly.GetExecutingAssembly().GetName().Version;

        private readonly ObservableCollection<KeyValuePair<IDataProvider, string>> Providers = new ObservableCollection<KeyValuePair<IDataProvider, string>>();
        private bool preventUpdate;

        private CollectionViewSource GroupedProviders { get; set; }

        public MainMenu()
        {
            var currentProviders = ((App)Application.Current).CurrentProject.CurrentProviders;
            Providers.AddAll(currentProviders.SelectMany(prov => prov.Repositories.Select(r => new KeyValuePair<IDataProvider, string>(prov, r.Key))));
            currentProviders.CollectionChanged += CurrentProviders_CollectionChanged;

            GroupedProviders = new CollectionViewSource()
            {
                Source = Providers
            };
            GroupedProviders.GroupDescriptions.Add(new PropertyGroupDescription("Key"));

            InitializeComponent();

            lstProviders.ItemsSource = GroupedProviders.View;
        }

        private void CurrentProviders_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (preventUpdate)
            {
                return;
            }

            using (GroupedProviders.DeferRefresh())
            {
                if (e.OldItems != null)
                {
                    e.OldItems.Cast<IDataProvider>().ToList().ForEach(x => Providers.Remove(Providers.First(prov => prov.Key == x)));
                }
                if (e.NewItems != null)
                {
                    Providers.AddAll((e.NewItems.Cast<IDataProvider>().SelectMany(prov => prov.Repositories.Select(r => new KeyValuePair<IDataProvider, string>(prov, r.Key)))));
                }
            }
        }

        private void btnDeleteProvider_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).CurrentProject.CurrentProviders.Remove((IDataProvider)((Button)sender).Tag);
        }

        private void btnImportPrv_Click(object sender, RoutedEventArgs e)
        {
            var dial = new OpenFileDialog() { CheckFileExists = true, ValidateNames = true, AddExtension = true, Filter = "QuAnalyzer Data Provider archive|*.qax" };
            if (dial.ShowDialog().Value)
            {
                ((App)Application.Current).ProvidersMan.AddProvider(dial.FileName);
            }
        }

        private void btnEditProvider_Click(object sender, RoutedEventArgs e) => Popup.OpenNew(new ProviderEditor((IDataProvider)((Button)sender).Tag));

        private void btnNewSource_Click(object sender, RoutedEventArgs e) => Popup.OpenNew(new ProviderPicker());

        private void lstProviders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            preventUpdate = true;

            var currentSelection = ((App)App.Current).CurrentSelection;
            currentSelection.RemoveRange(e.RemovedItems.Cast<KeyValuePair<IDataProvider, string>>());
            currentSelection.AddRange(e.AddedItems.Cast<KeyValuePair<IDataProvider, string>>());

            preventUpdate = false;
        }
    }
}
