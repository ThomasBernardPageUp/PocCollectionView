using PocCollectionView.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PocCollectionView.ViewModels
{
    public class DefaultCollectionViewModel : BaseViewModel
    {
        public IEnumerable<UserEntity> Users => UserFactory.GenerateUser(500);
        public ICommand UserTappedCommand { get; set; }
        public DefaultCollectionViewModel(INavigation navigation) : base(navigation)
        {
            UserTappedCommand = new Command(DisplayUser);
        }


        public void DisplayUser()
        {
            App.Current.MainPage.DisplayPromptAsync("User tapped", "You just tap a user", "Ok", "Cancel", "Yes", 8, Keyboard.Numeric, "11");
        }
    }
}
