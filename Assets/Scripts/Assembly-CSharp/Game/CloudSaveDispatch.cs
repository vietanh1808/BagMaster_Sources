using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Game
{
	public static class CloudSaveDispatch
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadCloudSaveFile_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<object> _003C_003Et__builder;

			public string fileName;

			public Type type;

			private UniTask<object>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadCloudSaves_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerInfo> _003C_003Et__builder;

			private UniTask<PlayerInfo>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadCloudSavesBatched_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerInfo> _003C_003Et__builder;

			private Dictionary<string, FieldInfo> _003CfieldInfos_003E5__2;

			private UniTask<Dictionary<string, object>>.Awaiter _003C_003Eu__1;

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

		private static readonly HashSet<string> _cloudIgnoredFields;

		private static readonly HashSet<string> _dirtyFiles;

		public static bool IsEnabled => false;

		public static bool IsSaving => false;

		public static bool LastSaveSucceeded => false;

		private static IEnumerable<string> CloudSyncedFields => null;

		public static void MarkDirty(string fileName)
		{
		}

		public static bool AnyDirtyIgnorePlayerData()
		{
			return false;
		}

		public static void SaveToCloud(PlayerInfo playerInfo, bool forceAll)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadCloudSaves_003Ed__13))]
		public static UniTask<PlayerInfo> LoadCloudSaves()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoadCloudSavesBatched_003Ed__14))]
		private static UniTask<PlayerInfo> LoadCloudSavesBatched()
		{
			return default;
		}

		public static void DeleteCloudFile(string fileName)
		{
		}

		public static void Clear()
		{
		}

		private static void SavePlayerFileData(PlayerInfo playerInfo, string file)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadCloudSaveFile_003Ed__18))]
		private static UniTask<object> LoadCloudSaveFile(string fileName, Type type)
		{
			return default;
		}

		private static void SaveCloudFile(string fileName, object objectToSave)
		{
		}

		private static void SaveCloudFiles(IEnumerable<(string FileName, object Data)> saveFiles)
		{
		}
	}
}
