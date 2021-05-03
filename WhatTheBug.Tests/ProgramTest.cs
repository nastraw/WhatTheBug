using NUnit.Framework;
using WhatTheBug.Core;

namespace WhatTheBug.Tests
{
	public class BugListViewModelTest
	{
		[Test]
		public void FormatBugList_WithBugList_OutputsListOfBugs()
		{
			var bugList = new Bugs();
			bugList.Add(new Bug("Test bug 1", "Test bug 1 description"));
			bugList.Add(new Bug("Test bug 2", "Test bug 2 description"));
			
			var viewModel = new BugListViewModel(bugList);

			var output = viewModel.FormatBugList();

			Assert.That(output, Does.Contain("Test bug 1").And.Contain("Test bug 2"));
		}
	}
}