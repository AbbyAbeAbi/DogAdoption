//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using Xamarin.Forms;

//namespace DoggoAdoption
//{
//    public class DogInfoViewModel
//    {
//        public ObservableCollection<DogInfo> DogInfoList { get; set; }

//        public DogInfoViewModel()
//        {
//            DogInfoList = new ObservableCollection<DogInfo> ();
//            DogInfoList.Add(new DogInfo() { DogId = 1, 
//                                            DogName="Keeper", 
//                                            DogType="Shih tzu", 
//                                            Sex="Male", 
//                                            Color="Black", 
//                                            Location="Cebu City",
//                                            Description = "Shih Tzus are affectionate, happy, outgoing house dogs who love nothing more than to follow their people from room to room.",
//                                            ImageUrl = "shihtzu.jpg"});
//            DogInfoList.Add(new DogInfo() { DogId = 2, 
//                                            DogName = "King", 
//                                            DogType = "Husky", 
//                                            Sex = "Male", 
//                                            Color = "Ash Gray", 
//                                            Location = "Cebu City", 
//                                            Description = "A Husky is very sociable and loves to be around all people. ",
//                                            ImageUrl = "Husky.jpg" });
//            DogInfoList.Add(new DogInfo() { DogId = 3, 
//                                            DogName = "Jack", 
//                                            DogType = "Pug", 
//                                            Sex = "Female", 
//                                            Color = "Black", 
//                                            Location = "Cebu City",
//                                            Description= "Pugs are highly adaptable, full of character and thrive in different environments.",
//                                            ImageUrl = "Pug.jpg" });
//            MessagingCenter.Subscribe<AddOrEditPage, DogInfo>(this, "AddOrEdit",(page,dog)=>
//            {
//                if (dog.DogId == 0)
//                {
//                    dog.DogId = DogInfoList.Count + 1;
//                    DogInfoList.Add(dog);
//                }
//                else
//                {
//                    DogInfo dogInfoForUpdate = DogInfoList.Where(e => e.DogId == dog.DogId).FirstOrDefault();

//                    int newIndex = DogInfoList.IndexOf(dogInfoForUpdate);
//                    DogInfoList.Remove(dogInfoForUpdate);
//                    DogInfoList.Add(dog);

//                    int oldIndex = DogInfoList.IndexOf(dog);
//                    DogInfoList.Move(oldIndex, newIndex);
//                }
//            });
//        }

//    }
//}
