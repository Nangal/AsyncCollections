﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellBrick.Collections.Internal
{
	/// <summary>
	/// Represents an abstract item awaiter.
	/// </summary>
	interface IAwaiter<T>
	{
		bool TrySetResult( T result );
		Task<T> Task { get; }
	}
}
