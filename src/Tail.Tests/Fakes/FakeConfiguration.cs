﻿using Caliburn.Micro;
using Tail.Extensibility;

namespace Tail.Tests.Fakes
{
	public class FakeConfiguration : Screen, ITailConfiguration
	{
		private readonly bool _result;

		public FakeConfiguration(bool result)
		{
			_result = result;
		}

		public bool Validate()
		{
			return _result;
		}
	}
}
