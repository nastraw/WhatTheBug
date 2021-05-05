using System;
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

		[Test]
		public void FormatBugList_WithBugList_OutputsFields()
		{
			var bugList = new Bugs();
			bugList.Add(new Bug("Test bug 1", "Test bug 1 description", new DateTime(1991,1,1)));
			
			var viewModel = new BugListViewModel(bugList);

			var output = viewModel.FormatBugList();

			Assert.That(output, Does.Contain("0"), "Output does not include Bug.BugId");
			Assert.That(output, Does.Contain("Test bug 1"), "Output does not include Bug.Title");
			Assert.That(output, Does.Contain("Test bug 1 description"), "Output does not include Bug.Description");
			Assert.That(output, Does.Contain("1/1/1991"), "Output does not include Bug.Created");
			Assert.That(output, Does.Contain("----"), "Output does not include Bug.Modified");
		}

		[Test]
		public void FormatBugList_WhenCalled_OutputsHeaderRow()
		{
			var bugList = new Bugs();
			bugList.Add(new Bug("Test bug 1", "Test bug 1 description", new DateTime(1991,1,1)));
			
			var viewModel = new BugListViewModel(bugList);
			var output = viewModel.FormatBugList();

			Assert.That(output, Does.Contain("BugId Title Description Created Modified" + Environment.NewLine));
		}
	}
}