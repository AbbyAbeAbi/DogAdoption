using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoggoAdoption
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddOrEditPage : ContentPage
    {
        public AddOrEditPage()
        {
            InitializeComponent();
        }

        async void BtnSave(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(dogName.Text) ||
                !string.IsNullOrWhiteSpace(dogType.Text) ||
                !string.IsNullOrWhiteSpace(dogSex.Text) ||
                !string.IsNullOrWhiteSpace(dogLocation.Text) ||
                !string.IsNullOrWhiteSpace(dogDescription.Text))
            {
                await App.Database.SaveDogAsync(new DogInfo
                {
                    ImageUrl = "shihtzu.png",
                    DogName = dogName.Text,
                    DogType = dogType.Text,
                    Sex = dogSex.Text,
                    Location = dogLocation.Text,
                    Description = dogLocation.Text
                });

                dogName.Text = string.Empty;
                dogType.Text = string.Empty;
                dogSex.Text = string.Empty;
                dogLocation.Text = string.Empty;
                dogDescription.Text = string.Empty;

                await App.Database.GetDogAsync();
            }
        }


        //public AddOrEditPage(DogInfo dogInfo=null)
        //{
        //    InitializeComponent();
        //    if(dogInfo !=null)
        //    {
        //        ((AddOrEditViewModel)BindingContext).Dog = dogInfo;
        //    }
        //}

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    DogInfo dog = ((AddOrEditViewModel)BindingContext).Dog;
        //    if (dog.DogId == 0)
        //    {
        //        dog.ImageUrl = "noImage.png";
        //    }
        //    MessagingCenter.Send(this, "AddOrEdit", dog);
        //    Navigation.PopAsync();
        //    DisplayAlert("", "Successfully Updated.", "OK");
        //}

        //private async void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    var pickImg = await FilePicker.PickAsync(new PickOptions() { 
        //        FileTypes = FilePickerFileType.Images,
        //        PickerTitle = "Choose an image"
        //    });

        //    if(pickImg != null)
        //    {
        //        var stream = await pickImg.OpenReadAsync();
        //        imgFile.Source = ImageSource.FromStream(() => stream);
        //        fileName.Text = pickImg.FileName;
        //    }
        //}


    }
}