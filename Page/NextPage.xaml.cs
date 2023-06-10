using OutLook.ViewModel;

namespace OutLook.Page;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();
		BindingContext = new FleshVM();
		//BindingContext = new RecipesVM();
	}

  //  private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
  //  {
		//try
		//{
  //          Frame tappedFrame = (Frame)sender;
  //          var frameContent = tappedFrame.Content;

          

  //          var gridType = frameContent.GetType();
  //          if (gridType == typeof(Grid))
  //          {
  //            // var innerGrid = frameContent as Grid;
  //              var innerGrid = (Grid)frameContent;

  //              if (innerGrid != null) 
  //              {

  //                  var gridChildren = innerGrid.Children;
  //                  var foodLabel = gridChildren[1];

  //                  var labelType = foodLabel.GetType();

  //                  if(labelType == typeof(Label)) 
  //                  {
  //                      var myFoodLabel = (Label)foodLabel;

  //                      var foodName = myFoodLabel.Text;

  //                      Shell.Current.GoToAsync($"MealsPage?FoodName={foodName}");

  //                  }

  //              }
  //             //frameContent.Con




                
  //          }

  //          //Shell.Current.GoToAsync("MealsPage");

  //          //	DisplayAlert(FoodName.Text);
  //      }
		//catch (Exception ex)
		//{

		//	DisplayAlert(ex.Message,"Error","ok");
		//}
		
  //  }
}