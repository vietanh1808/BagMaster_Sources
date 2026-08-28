using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MoreMountains.Tools;
using UnityEngine;

namespace Game
{
	public class LocalSaveService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleSaveFileIoAsyn_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Awaitable.AwaitableAsyncMethodBuilder _003C_003Et__builder;

			public LocalSaveService _003C_003E4__this;

			public string fileName;

			public object saveData;

			private string _003CfolderPath_003E5__2;

			private BackgroundThreadAwaitable _003C_003Eu__1;

			private MainThreadAwaitable _003C_003Eu__2;

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
		private struct _003CSaveObjectAsyn_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Awaitable.AwaitableAsyncMethodBuilder _003C_003Et__builder;

			public LocalSaveService _003C_003E4__this;

			public string fileName;

			public object saveData;

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

		private readonly string _folder;

		private readonly MMSaveLoadManagerMethodJsonEncrypted _encrypter;

		private List<string> _inProgress;

		public LocalSaveService(string folder, string encryptionKey)
		{
		}

		public bool IsInProgress(string fileName)
		{
			return false;
		}

		public bool IsCompleteAll()
		{
			return false;
		}

		public void OnPreprogress(string fileName)
		{
		}

		public void SaveObject(string fileName, object saveData)
		{
		}

		[AsyncStateMachine(typeof(_003CSaveObjectAsyn_003Ed__8))]
		public Awaitable SaveObjectAsyn(string fileName, object saveData)
		{
			return null;
		}

		private void HandleSaveFileIo(string fileName, object saveData)
		{
		}

		[AsyncStateMachine(typeof(_003CHandleSaveFileIoAsyn_003Ed__10))]
		private Awaitable HandleSaveFileIoAsyn(string fileName, object saveData)
		{
			return null;
		}

		private void SaveFile(string fileName, string folder, object saveData)
		{
		}

		public object LoadObject(string fileName, Type type, Func<object> @default)
		{
			return null;
		}

		private object TryRecoverFromTemp(string fileName, Type type)
		{
			return null;
		}

		private void Log(string msg)
		{
		}
	}
}
