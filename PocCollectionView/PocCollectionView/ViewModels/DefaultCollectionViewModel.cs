using PocCollectionView.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PocCollectionView.ViewModels
{
    public class DefaultCollectionViewModel : BaseViewModel
    {
        public IEnumerable<UserEntity> Users => UserFactory.GenerateUser();
        public DefaultCollectionViewModel(INavigation navigation) : base(navigation)
        {
        }
    }
}
