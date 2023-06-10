using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLook.ViewModel
{
    [QueryProperty(nameof(FoodNameProp), "FoodNameProp")]
    public partial class MealsVM : BaseViewModel
    {

      //  [ObservableProperty]
       public string _foodNameProp;

        public string FoodNameProp
        {
            get => _foodNameProp; 
            set => SetProperty(ref _foodNameProp, value);
        }




    }
}
