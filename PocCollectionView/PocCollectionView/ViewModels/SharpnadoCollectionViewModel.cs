using PocCollectionView.Models;
using Sharpnado.CollectionView.RenderedViews;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PocCollectionView.ViewModels
{
    public class SharpnadoCollectionViewModel : BaseViewModel
    {
        public IEnumerable<UserEntity> Users => UserFactory.GenerateUser(5);


        public SharpnadoCollectionViewModel(INavigation navigation) : base(navigation)
        {
        }
    }
}
