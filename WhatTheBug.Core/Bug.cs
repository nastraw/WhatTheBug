namespace WhatTheBug.Core
{
	public class Bug
	{
		public string Title { get; private set; }
		public string Description { get; private set; }

		public Bug(string title, string description)
		{
			Title = title;
			Description = description;
		}
	}
}