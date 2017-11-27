using System.Threading.Tasks;

namespace CodeMill.VMFirstNav
{
	// Marker interface
	public interface IViewModel
	{
		Task OnAppearing(); //Workloud
		Task OnDisappearing(); //Workloud
		bool OnBackButtonPressed(); //Workloud
	}
}
