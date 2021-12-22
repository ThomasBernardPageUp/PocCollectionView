using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocCollectionView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Sharpnado.CollectionView.Initializer.Initialize(true, false);
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
