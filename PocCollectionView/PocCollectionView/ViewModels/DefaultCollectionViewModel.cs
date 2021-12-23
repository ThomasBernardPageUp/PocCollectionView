using PocCollectionView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PocCollectionView.ViewModels
{
    public class DefaultCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<UserEntity> Users { get; set; }
        public ICommand UserTappedCommand { get; set; }
        public DefaultCollectionViewModel(INavigation navigation) : base(navigation)
        {
            Users = new ObservableCollection<UserEntity>(UserFactory.GenerateUser(2000));
            UserTappedCommand = new Command(DisplayUser);
        }


        public void DisplayUser()
        {
            App.Current.MainPage.DisplayPromptAsync("User tapped", "You just tap a user", "Ok", "Cancel", "Yes", 8, Keyboard.Numeric, "11");
        }
    }
}
