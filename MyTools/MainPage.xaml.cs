﻿namespace MyTools
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnPasswordMakerClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PasswordMakerPage));
        }
    }

}
