﻿namespace CodeMill.VMFirstNav
{
	public class MasterListItem<T> : IMasterListItem<T> where T : class, IViewModel
	{
		public T ViewModel { get; }
		public string DisplayName { get; set; }
		public string Group { get; set; }

		public MasterListItem(string displayName)
		{
			DisplayName = displayName;
		}
	}
}
