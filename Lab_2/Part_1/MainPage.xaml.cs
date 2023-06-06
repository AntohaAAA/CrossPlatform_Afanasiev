using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        
        private ObservableCollection<string> items;
        

        public MainPage()
        {
            InitializeComponent();
            items = new ObservableCollection<string>();
            listView.ItemsSource = items;
            string text = "AAAAA";
            items.Add(text);
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            string text = entry.Text;
            if (!string.IsNullOrEmpty(text))
            {
                items.Add(text);
                entry.Text = string.Empty;
            }
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var item = button.BindingContext as string;
            items.Remove(item);
        }

        private void OnItemSelected(object sender, EventArgs e)
        {
            var item = (sender as ListView).SelectedItem as string;
            labelSelectedItem.Text = item;
        }
    }
}

