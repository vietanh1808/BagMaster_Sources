using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace _KIT.Resource
{
	public static class KitLoaded
	{
		private class CacheEntry
		{
			public AsyncOperationHandle Handle;

			public object Asset;

			public CacheEntry(AsyncOperationHandle handle, object asset)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0<T> where T : class
		{
			public AsyncOperationHandle<T> handle;

			internal void _003CLoadAsync_003Eb__0(AsyncOperationHandle<T> _)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadAsync_003Ed__2<T> : IAsyncStateMachine where T : class
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public bool cached;

			public string path;

			private _003C_003Ec__DisplayClass2_0<T> _003C_003E8__1;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static readonly Dictionary<string, CacheEntry> dictionary;

		[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__2<>))]
		public static UniTask<T> LoadAsync<T>(string path, bool cached = false) where T : class
		{
			return default;
		}

		public static void UnCache(string path)
		{
		}

		public static void ClearCache()
		{
		}

		public static bool IsCached(string path)
		{
			return false;
		}
	}
}
