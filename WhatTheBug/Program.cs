using System;
using WhatTheBug.Core;

namespace WhatTheBug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bugs bugList = new Bugs();
            AddSampleBugs(bugList);
            
            switch (args[0])
            {
                case "list":
                    var viewModel = new BugListViewModel(bugList);
                    Console.WriteLine(viewModel.FormatBugList());
                    break;
                default:
                    Console.WriteLine("Command not recognized");
                    break;
            }
        }

        private static void AddSampleBugs(Bugs bugList)
        {
            bugList.Add(new Bug("Sample Bug 1", "Sample bug 1 description"));
            bugList.Add(new Bug("Sample Bug 2", "Sample bug 2 description"));
        }
    }
}