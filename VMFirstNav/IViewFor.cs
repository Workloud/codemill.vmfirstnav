using System;

namespace CodeMill.VMFirstNav
{
	// IViewFor should only be a marker interface
	public interface IViewFor
	{
		event EventHandler Appearing; //Workloud
		event EventHandler Disappearing; //Workloud
		Func<bool> OnBackButtonPressed { get; set; } //Workloud
	}

	public interface IViewFor<T> : IViewFor where T : IViewModel
	{
		T ViewModel { get; set; }
	}
}
