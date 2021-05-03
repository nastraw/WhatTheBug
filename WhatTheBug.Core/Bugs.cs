using System.Collections;
using System.Collections.Generic;

namespace WhatTheBug.Core
{
	public class Bugs : IEnumerable<Bug>
	{
		private List<Bug> _bugList = new List<Bug>();

		public void Add(Bug bug)
		{
			_bugList.Add(bug);
		}
		
		public IEnumerator<Bug> GetEnumerator()
		{
			return _bugList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}