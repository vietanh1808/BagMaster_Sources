using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DoorServices
{
	public static class CloudSaveServices
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteGloudFile_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string fileName;

			private TaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadCloudSaveFile_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Awaitable.AwaitableAsyncMethodBuilder<object> _003C_003Et__builder;

			public string fileName;

			public Type type;

			private TaskAwaiter<byte[]> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveCloudFile_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Awaitable.AwaitableAsyncMethodBuilder _003C_003Et__builder;

			public string dataInStr;

			public string fileName;

			private byte[] _003Cbytes_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveCloudFile_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public object objectToSave;

			public string fileName;

			private Awaitable.Awaiter _003C_003Eu__1;

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

		public static DateTime LastSyncTime;

		private static Dictionary<string, object> _loadedCloudData;

		private static Dictionary<string, byte[]> _latestSaveData;

		public static bool InSavingProgress { get; private set; }

		public static bool LatestSavingResult { get; private set; }

		public static object GetLoadedData(string fileName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadCloudSaveFile_003Ed__12))]
		public static Awaitable<object> LoadCloudSaveFile(string fileName, Type type)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSaveCloudFile_003Ed__13))]
		private static Awaitable SaveCloudFile(string fileName, string dataInStr)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSaveCloudFile_003Ed__14))]
		public static void SaveCloudFile(string fileName, object objectToSave)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteGloudFile_003Ed__15))]
		public static void DeleteGloudFile(string fileName)
		{
		}

		public static void Log(string msg)
		{
		}

		public static void LogTest(string msg)
		{
		}

		public static void Clear()
		{
		}
	}
}
