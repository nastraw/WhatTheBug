using System;

namespace WhatTheBug.Core
{
	public class Bug
	{
		public int BugId { get; private set; }
		public string Title { get; private set; }
		public string Description { get; private set; }
		public DateTime Created { get; set; }
		public DateTime? Modified { get; set; }
		public DateTime? Resolved { get; set; }

		public Bug(string title, string description)
		{
			Title = title;
			Description = description;
			Created = DateTime.Now;
		}

		public Bug(string title, string description, DateTime created)
			: this(title, description)
		{
			Created = created;
		}
	}
}