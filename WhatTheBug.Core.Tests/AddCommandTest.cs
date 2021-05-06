using NUnit.Framework;

namespace WhatTheBug.Core.Tests
{
	public class AddCommandTest
	{
		[TestCase(null)]
		[TestCase("")]
		public void Ctor_WithNullOrEmptyTitle_ThrowsArgumentException(string title)
		{
			var bugList = new Bugs();
			
			Assert.That(() => new AddCommand(title, "test description"), Throws.ArgumentException);
		}
		
		[TestCase(null)]
		[TestCase("")]
		public void Ctor_WithNullOrEmptyDescription_ThrowsArgumentException(string description)
		{
			var bugList = new Bugs();
			
			Assert.That(() => new AddCommand("test title", description), Throws.ArgumentException);
		}
	}
}