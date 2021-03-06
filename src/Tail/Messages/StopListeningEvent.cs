﻿using System;

namespace Tail.Messages
{
	public sealed class StopListeningEvent
	{
		private readonly int _threadId;

		public int ThreadId
		{
			get { return _threadId; }
		}

		public StopListeningEvent(int threadId)
		{
			if (threadId <= 0)
			{
				throw new ArgumentException(@"Thread ID must be greater than zero.", "threadId");
			}
			_threadId = threadId;
		}
	}
}
