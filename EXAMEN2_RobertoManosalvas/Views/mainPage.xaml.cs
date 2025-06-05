using System;
using Microsoft.Maui.Controls;

namespace EXAMEN2_RobertoManosalvas.Views
{
    public partial class mainPage : ContentPage
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutPageButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new aboutPage());
        }

        private async void OnJokesPageButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new jokesPage());
        }
    }
}
