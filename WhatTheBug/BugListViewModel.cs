using System;
using System.Linq;
using WhatTheBug.Core;

namespace WhatTheBug
{
	public class BugListViewModel
	{
		private readonly Bugs _bugList;

		public BugListViewModel(Bugs bugList)
		{
			_bugList = bugList;
		}

		public string FormatBugList()
		{
			return string.Join(Environment.NewLine, _bugList.Select(FormatBugRecord));
		}

		private string FormatBugRecord(Bug bug)
		{
			return $"{bug.BugId}, {bug.Title}, {bug.Description}, {bug.Created}, {bug.Modified?.ToString() ?? "-----"}";
		}
	}
}