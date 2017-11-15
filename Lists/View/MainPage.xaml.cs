using System;
using System.Collections.Generic;
using Lists.Model;
using Lists.ViewModel;
using Xamarin.Forms;

namespace Lists.View
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            vm = new MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();
        }
        public void OnItemTapped(object o, ItemTappedEventArgs e)
        {
            var per = e.Item as Person;
            DisplayAlert("Selection made","You tapped on " + per.FullName, "Ok");
        }
    }
}
