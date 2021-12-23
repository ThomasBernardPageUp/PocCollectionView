using PocCollectionView.Models;
using Sharpnado.CollectionView.RenderedViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PocCollectionView.ViewModels
{
    public class SharpnadoCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<UserEntity> Users { get; set; }
        public ICommand UserTappedCommand { get; set; }


        public SharpnadoCollectionViewModel(INavigation navigation) : base(navigation)
        {
            Users = new ObservableCollection<UserEntity>(UserFactory.GenerateUser(5));
        }

        public void DisplayUser()
        {
            App.Current.MainPage.DisplayPromptAsync("User tapped", "You just tap a user", "Ok", "Cancel", "Yes", 8, Keyboard.Numeric, "11");
        }
    }
}
