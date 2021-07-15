using monkey.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace monkey.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}