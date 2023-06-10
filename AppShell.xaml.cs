
using OutLook.Page;
namespace OutLook;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("MealsPage", typeof(MealsPage));
        Routing.RegisterRoute("NextPage", typeof(NextPage));
    
    }
}
