using OutLook.ViewModel;
using System.Globalization;

namespace OutLook.Page;


public partial class MealsPage : ContentPage
{
	//private MealsVM vm;
	//public String FoodName
	//{
	//	set => vm.FoodNameProp = value;
	//}

	public MealsPage(MealsVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}