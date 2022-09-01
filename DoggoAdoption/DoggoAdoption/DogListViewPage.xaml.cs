using Android.App;
using Android.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoggoAdoption
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogListViewPage : ContentPage
    {
        //AlertDialog.Builder build;
        public DogListViewPage()
        {
            InitializeComponent();
            //BindingContext = new DogInfoViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetDogAsync();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddOrEditPage());
        }

        //private void ImageButton_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new AddOrEditPage());
        //}

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
        //    DogInfo dogInfo = ((DogInfoViewModel)BindingContext).DogInfoList.Where(dog => dog.DogId == (int)tappedEventArgs.Parameter).FirstOrDefault();

        //    Navigation.PushAsync(new AddOrEditPage(dogInfo));
        //}

        //private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        //{

        //    TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
        //    DogInfo dogInfo = ((DogInfoViewModel)BindingContext).DogInfoList.Where(dog => dog.DogId == (int)tappedEventArgs.Parameter).FirstOrDefault();

        //    ((DogInfoViewModel)BindingContext).DogInfoList.Remove(dogInfo);
        //    await DisplayAlert(" ", "Successfully Deleted.", "OK");
        //}

        //private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        //{
        //    var details = e.Item as DogInfo;
        //    await Navigation.PushAsync(new DogInfoDetailsPage(details.DogName, details.Description, details.DogType, details.Sex, details.Color, details.Location, details.ImageUrl));

        //}
    }
}