using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PocCollectionView.ViewModels
{
    public class BaseViewModel
    {
        public INavigation NavigationService { get; set; }


        public BaseViewModel(INavigation navigation)
        {
            NavigationService = navigation;
        }
    }
}
