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
    public partial class DogInfoDetailsPage : ContentPage
    {
        public DogInfoDetailsPage(string DogName, string Description, string DogType, string DogSex, string DogColor, string DogLocation, string ImageUrl)
        {
            InitializeComponent();

            DogInfoName.Text = DogName;
            DogDescription.Text = Description;
            DogInfoType.Text = DogType;
            DogInfoSex.Text = DogSex;
            DogInfoColor.Text = DogColor;
            DogInfolocation.Text = DogLocation;
            ImgSource.Source = ImageUrl;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert(" ", DogInfoName.Text + " is adopted successfully.", "OK");
        }
    }
}