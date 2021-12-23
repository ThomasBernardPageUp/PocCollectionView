using PocCollectionView.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PocCollectionView.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand DefaultCollectionCommand { get; set; }
        public ICommand SharpnadoCollectionCommand { get; set; }

        public MainViewModel(INavigation navigation):base(navigation)
        {
            DefaultCollectionCommand = new Command(DefaultCollection);
            SharpnadoCollectionCommand = new Command(SharpnadoCollection);
        }

        public void DefaultCollection()
        {
            NavigationService.PushAsync(new DefaultCollectionPage());
        }

        public void SharpnadoCollection()
        {
            NavigationService.PushAsync(new SharpnadoCollectionPage());
        }
    }
}
