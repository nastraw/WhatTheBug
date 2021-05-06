using NUnit.Framework;

namespace WhatTheBug.Core.Tests
{
    public class BugsTest
    {
        [Test]
        public void Add_WithBug_AddsBugToBugList()
        {
            Bugs bugList = new Bugs();
            bugList.Add(new Bug("Test bug 1", "Test bug 1 description"));
            bugList.Add(new Bug("Test bug 2", "Test bug 2 description"));

            Assert.That(bugList, Is.Not.Empty);
        }
    }
}