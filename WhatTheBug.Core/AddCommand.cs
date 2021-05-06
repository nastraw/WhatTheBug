using System;

namespace WhatTheBug.Core
{
	public class AddCommand
	{
		private readonly string _title;
		private readonly string _description;

		public AddCommand(string title, string description)
		{
			if (string.IsNullOrWhiteSpace(title))
				throw new ArgumentException("Add command requires a valid title parameter");
			
			if (string.IsNullOrWhiteSpace(description))
				throw new ArgumentException("Add command requires a valid description parameter");

			_description = description;
			_title = title;
		}
		public void Add(Bugs bugList)
		{
			bugList.Add(new Bug(_title, _description));
		}
	}
}