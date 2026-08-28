using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Nakama;
using Newtonsoft.Json;

namespace DoorServices
{
	public static class SayGamesCloudSaveServices
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBatchDataAndSave_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IEnumerable<(string FileName, string Data)> saveFiles;

			public IClient client;

			public ISession session;

			private TaskAwaiter<IApiStorageObjectAcks> _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003CConvertToSaveFormat_003Ed__27 : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (string FileName, string Data) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<(string FileName, object Data)> saveFiles;

			public IEnumerable<(string FileName, object Data)> _003C_003E3__saveFiles;

			private IEnumerator<(string FileName, object Data)> _003C_003E7__wrap1;

			(string, string) IEnumerator<(string, string)>.Current
			{
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EStringFileName_002CSystem_002EStringData_0029_003E_002Eget_Current();
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
			public _003CConvertToSaveFormat_003Ed__27(int _003C_003E1__state)
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
			private (string, string) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EStringFileName_002CSystem_002EStringData_0029_003E_002Eget_Current()
			{
				return default;
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<(string, string)> IEnumerable<(string, string)>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteCloudFile_003Ed__30 : IAsyncStateMachine
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
		private struct _003CLoadCloudSaveFile_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<object> _003C_003Et__builder;

			public string fileName;

			public Type type;

			private UniTask<IApiStorageObjects>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadCloudSaveFilesBatch_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<Dictionary<string, object>> _003C_003Et__builder;

			public IEnumerable<(string fileName, Type type)> files;

			private Dictionary<string, object> _003Cresult_003E5__2;

			private List<IApiReadStorageObjectId> _003Cids_003E5__3;

			private Dictionary<string, Type> _003CtypeMap_003E5__4;

			private UniTask<IApiStorageObjects>.Awaiter _003C_003Eu__1;

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
		private struct _003CReadWithRetry_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<IApiStorageObjects> _003C_003Et__builder;

			public IClient client;

			public ISession session;

			public IApiReadStorageObjectId[] ids;

			private int _003Cattempt_003E5__2;

			private TaskAwaiter<IApiStorageObjects> _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003CSaveCloudFile_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public object objectToSave;

			public string fileName;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private struct _003CSaveCloudFile_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string fileName;

			public string dataInStr;

			private TaskAwaiter<IApiStorageObjectAcks> _003C_003Eu__1;

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
		private struct _003CSaveCloudFiles_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IEnumerable<(string FileName, string Data)> saveFiles;

			private UniTask.Awaiter _003C_003Eu__1;

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

		private static int _inFlightSaves;

		private const int LoadMaxAttempts = 3;

		private const int LoadRetryDelayMs = 1000;

		private const string DefaultCollection = "player_data";

		private static readonly Regex ValidKeyRegex;

		private static readonly Dictionary<string, object> _loadedCloudData;

		private static readonly Dictionary<string, string> _latestSaveData;

		private static readonly JsonSerializerSettings SaveSettings;

		public static bool InSavingProgress => false;

		public static bool LatestSavingResult { get; private set; }

		public static bool LoadFailed { get; private set; }

		public static object GetLoadedData(string fileName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadCloudSaveFile_003Ed__20))]
		public static UniTask<object> LoadCloudSaveFile(string fileName, Type type)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoadCloudSaveFilesBatch_003Ed__21))]
		public static UniTask<Dictionary<string, object>> LoadCloudSaveFilesBatch(IEnumerable<(string fileName, Type type)> files)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CReadWithRetry_003Ed__22))]
		private static UniTask<IApiStorageObjects> ReadWithRetry(IClient client, ISession session, IApiReadStorageObjectId[] ids)
		{
			return default;
		}

		private static object DeserializeAndCache(string fileName, string dataInStr, Type type)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSaveCloudFile_003Ed__24))]
		public static UniTask SaveCloudFile(string fileName, object objectToSave)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSaveCloudFile_003Ed__25))]
		private static UniTask SaveCloudFile(string fileName, string dataInStr)
		{
			return default;
		}

		public static UniTask SaveCloudFiles(IEnumerable<(string FileName, object Data)> saveFiles)
		{
			return default;
		}

		[IteratorStateMachine(typeof(_003CConvertToSaveFormat_003Ed__27))]
		private static IEnumerable<(string, string)> ConvertToSaveFormat(IEnumerable<(string FileName, object Data)> saveFiles)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSaveCloudFiles_003Ed__28))]
		private static UniTask SaveCloudFiles(IEnumerable<(string FileName, string Data)> saveFiles)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CBatchDataAndSave_003Ed__29))]
		private static UniTask BatchDataAndSave(IEnumerable<(string FileName, string Data)> saveFiles, IClient client, ISession session)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CDeleteCloudFile_003Ed__30))]
		public static void DeleteCloudFile(string fileName)
		{
		}

		public static void Clear()
		{
		}

		public static void Log(string msg)
		{
		}

		public static void LogTest(string msg)
		{
		}

		private static bool TryGetSession(out IClient client, out ISession session)
		{
			client = null;
			session = null;
			return false;
		}

		private static bool IsValidKey(string key)
		{
			return false;
		}
	}
}
