﻿using MahApps.Metro.Controls;
using Wokhan.Data.Providers.Bases;
using Wokhan.Data.Providers.Contracts;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.ComponentModel;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace QuAnalyzer.UI.Windows
{
    /// <summary>
    /// Interaction logic for ProviderPage.xaml
    /// </summary>
    public partial class ProvidersEditor : MetroWindow, INotifyPropertyChanged
    {
        private IDataProvider _currentProvider;
        public IDataProvider CurrentProvider
        {
            get { return _currentProvider; }
            set { _currentProvider = value; NotifyPropertyChanged("CurrentProvider"); NotifyPropertyChanged("CurrentType"); fillProvider(); }
        }

        public DataProviderStruct CurrentType
        {
            get { return CurrentProvider.ProviderTypeInfo; }
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class RepositoryView
        {
            public bool Selected { get; set; }
            public string Key { get; set; }
            public object Value { get; set; }
        }

        public ObservableCollection<RepositoryView> Repositories { get; } = new ObservableCollection<RepositoryView>();

        public ProvidersEditor(IDataProvider currentProvider)
        {
            Repositories.CollectionChanged += Repositories_CollectionChanged;

            CurrentProvider = currentProvider;

            InitializeComponent();
        }

        void Repositories_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (RepositoryView repo in e.NewItems)
                {
                    CurrentProvider.RemoveCachedHeaders(repo.Key);
                }
            }

            if (e.OldItems != null)
            {
                foreach (RepositoryView repo in e.OldItems)
                {
                    CurrentProvider.RemoveCachedHeaders(repo.Key);
                }
            }
        }

        private void fillProvider()
        {
            if (CurrentProvider.Repositories != null)
            {
                foreach (var r in CurrentProvider.Repositories)
                {
                    Repositories.Add(new RepositoryView() { Key = r.Key, Value = r.Value, Selected = true });
                }
            }
        }

        void rdb_Checked(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked.Value)
            {
                CurrentProvider.SelectedGroups.Add(((RadioButton)sender).Name);
            }
            else
            {
                CurrentProvider.SelectedGroups.Remove(((RadioButton)sender).Name);
            }
        }


        private void save()
        {
            ((IDataProvider)CurrentProvider).Repositories = Repositories.Where(r => r.Selected).ToDictionary(r => r.Key, r => r.Value);

            if (!((App)Application.Current).CurrentProject.CurrentProviders.Contains(CurrentProvider))
            {
                ((App)Application.Current).CurrentProject.CurrentProviders.Add(CurrentProvider);
            }
            //((App)App.Current).CurrentProject.CurrentProviders[((App)App.Current).CurrentProject.CurrentProviders.IndexOf((IDataProvider)lstProviders.SelectedItem)] = CurrentProvider;

            Close();
            //if (lstProviders.SelectedItem == null)
            ////{
            ////((App)App.Current).CurrentProject.CurrentProviders[((App)App.Current).CurrentProject.CurrentProviders.IndexOf((IDataProvider)lstProviders.SelectedItem)] = currentProvider;
            ////lstProviders.Items.Refresh();
            ////}
            ////else
            //{
            //    ((App)App.Current).CurrentProject.CurrentProviders.Add(currentProvider);
            //}

            //lstProviders.SelectedItem = currentProvider;
        }

        private async void btnRepoRetr_Click(object sender, RoutedEventArgs e)
        {
            var msg = await this.ShowProgressAsync("Please wait", "Retrieving repositories...", true);

            string res = null;
            try
            {
                msg.SetIndeterminate();

                await Task.Run(() =>
                {
                    var reps = CurrentProvider.GetDefaultRepositories().OrderBy(r => r.Key).Select(r => new RepositoryView() { Key = r.Key, Value = r.Value, Selected = true });
                    foreach (var r in reps)
                    {
                        Dispatcher.Invoke(() => Repositories.Add(r));

                        if (msg.IsCanceled)
                        {
                            break;
                        }
                    }
                });

                await msg.CloseAsync();
            }
            catch (Exception exc)
            {
                res = exc.Message;
                /*msg.SetMessage(exc.Message);
                msg.SetProgress(0);
                msg.SetTitle("Unexpected error");*/
            }

            if (res != null)
            {
                await msg.CloseAsync();
                await this.ShowMessageAsync("Unexpected error", res);
            }
            /*catch (Exception exc)
            {
                ForceDialog("Something went wrong (and this message will get better later). Press OK to continue.", "Unexpected error");
            }*/
        }

        /*private async void ForceDialog(string p1, string p2)
        {
            var dial = await this.GetCurrentDialogAsync<BaseMetroDialog>();
            if (dial != null)
            {
                dial.Title = p2;
                dial.Content = p1;
                //await this.HideMetroDialogAsync(dial);
            }
            else
            {
                await this.ShowMessageAsync(p2, p1, MessageDialogStyle.Affirmative);
            }
        }
        */

        private void btnRepoClear_Click(object sender, RoutedEventArgs e)
        {
            Repositories.Clear();
        }

        private void btnRepoSel_Click(object sender, RoutedEventArgs e)
        {
            foreach (var r in Repositories)
            {
                r.Selected = true;
            }

            gridRepositories.Items.Refresh();
        }

        private void btnRepoUnSel_Click(object sender, RoutedEventArgs e)
        {
            foreach (var r in Repositories)
            {
                r.Selected = false;
            }

            gridRepositories.Items.Refresh();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /*private void btnNewPrv_Click(object sender, RoutedEventArgs e)
        {
            CurrentProvider = (IDataProvider)Activator.CreateInstance(DataProvider.AllProviders.First().Type);
            CurrentProvider.Name = "Provider #" + (lstProviders.Items.Count + 1);

            ((App)Application.Current).CurrentProject.CurrentProviders.Add(CurrentProvider);

            fillProvider();
        }*/

        private void btnRepoAdd_Click(object sender, RoutedEventArgs e)
        {
            Repositories.Add(new RepositoryView() { Key = "Repository #" + (Repositories.Count + 1), Selected = true });
        }

        private void btnDeleteProvider_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).CurrentProject.CurrentProviders.Remove((IDataProvider)((Button)sender).Tag);
        }

        private void btnDeleteRepo_Click(object sender, RoutedEventArgs e)
        {
            Repositories.Remove((RepositoryView)((Button)sender).Tag);
        }

        private void btnRevert_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            string res;
            txtTestResult.Text = "Testing...";
            CurrentProvider.Test(out res);
            txtTestResult.Text = res;
        }

        private void ShowFileDialog(object sender, RoutedEventArgs e)
        {
            var txt = (DataProviderMemberStruct)((Button)sender).Tag;
            var dial = new OpenFileDialog() { CheckFileExists = true, ValidateNames = true, AddExtension = true, Filter = txt.FileFilter };
            if (dial.ShowDialog().Value)
            {
                txt.ValueWrapper = dial.FileName;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnNext.Content == "Finish")
            {
                save();
            }
            else
            {
                dockRepositories.Visibility = System.Windows.Visibility.Visible;
                gridParameters.Visibility = System.Windows.Visibility.Hidden;
                btnBack.IsEnabled = true;
                btnNext.Content = "Finish";
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            dockRepositories.Visibility = System.Windows.Visibility.Hidden;
            gridParameters.Visibility = System.Windows.Visibility.Visible;
            btnNext.Content = "Next >";
            btnBack.IsEnabled = false;
        }
    }
}
