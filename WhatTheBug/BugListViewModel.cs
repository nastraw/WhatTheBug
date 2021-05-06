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
			return FormatOutputRow("BugId", "Title", "Description", "Created", "Modified") + Environment.NewLine + string.Join(Environment.NewLine, _bugList.Select(FormatBugRecord));
		}

		private string FormatBugRecord(Bug bug)
		{
			return FormatOutputRow(bug.BugId.ToString(), bug.Title, bug.Description, bug.Created.ToString(), bug.Modified?.ToString() ?? "-----");
		}

		private string FormatOutputRow(params string[] args)
		{
			return string.Format("{0, 5} {1, -20} {2, -50} {3, -22} {4, -22}", args);
		}
	}
}