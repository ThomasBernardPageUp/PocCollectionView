using PocCollectionView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocCollectionView.Views
{
    public partial class SharpnadoCollectionPage : ContentPage
    {
        public SharpnadoCollectionPage()
        {
            this.BindingContext = new SharpnadoCollectionViewModel(Navigation);
            InitializeComponent();
        }
    }
}