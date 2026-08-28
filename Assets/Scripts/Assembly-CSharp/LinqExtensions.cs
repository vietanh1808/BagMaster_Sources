using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class LinqExtensions
{
	[CompilerGenerated]
	private sealed class _003CDistinctBy_003Ed__0<TSource, TKey> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private TSource _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<TSource> source;

		public IEnumerable<TSource> _003C_003E3__source;

		private Func<TSource, TKey> keySelector;

		public Func<TSource, TKey> _003C_003E3__keySelector;

		private HashSet<TKey> _003CseenKeys_003E5__2;

		private IEnumerator<TSource> _003C_003E7__wrap2;

		TSource IEnumerator<TSource>.Current
		{
			[DebuggerHidden]
			get
			{
				return default;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDistinctBy_003Ed__0(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[IteratorStateMachine(typeof(_003CDistinctBy_003Ed__0<, >))]
	public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return null;
	}
}
