namespace CodeMill.VMFirstNav
{
	public interface IMasterListItem<out T> where T : class, IViewModel
	{
		T ViewModel { get; }
		string DisplayName { get; set; }
		string Group { get; set; }
	}
}
