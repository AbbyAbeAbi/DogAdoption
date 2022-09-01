//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;
//using System.Text;

//namespace DoggoAdoption
//{
//    public class AddOrEditViewModel : INotifyPropertyChanged
//    {
//        public DogInfo _dogInfo;


//        public DogInfo Dog {
//            get { return _dogInfo; }
//            set { _dogInfo = value;
//                OnPropertyChanged();
//            }
//        }
//        public AddOrEditViewModel()
//        {
//            Dog = new DogInfo();
//        }

//        public event PropertyChangedEventHandler PropertyChanged;

//        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
//        {
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        }
//    }
//}
