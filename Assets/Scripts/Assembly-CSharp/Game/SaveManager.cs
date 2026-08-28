using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Game
{
	public class SaveManager
	{
		private class SaveOrder
		{
			public string FileName;

			public object ObjectToSave;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConfirmFullCloudSyncAsync_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SaveManager _003C_003E4__this;

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
		private struct _003CLoadCloudSaves_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public SaveManager _003C_003E4__this;

			private PlayerInfo _003CfromCloud_003E5__2;

			private UniTask<PlayerInfo>.Awaiter _003C_003Eu__1;

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
		private struct _003CWaitSavingCompleted_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public SaveManager _003C_003E4__this;

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

		internal static readonly List<string> DataTables;

		private const string EncryptionKey = "doorkey";

		private const string SaveFileExtension = ".dat";

		private const string SaveFolder = "PlayerInfo";

		private const string GuestSaveFolder = "PlayerInfo_Guest";

		private const string GuestBackupDonePrefKey = "GuestBackupDone";

		private const float IntervalCloudSaveInSeconds = 120f;

		private LocalSaveService _localSaveService;

		private LocalSaveService _guestLocalSaveService;

		private PlayerInfo _playerInfoLoadedFromCloud;

		private List<SaveOrder> _saveOrders;

		public static SaveManager Instance { get; private set; }

		internal static IEnumerable<string> AllDataFields => null;

		public bool NeedsFullCloudSync { get; private set; }

		public static bool IsCloudSaveUnlocked => false;

		private SaveManager()
		{
		}

		public PlayerInfo LoadPlayerInfo()
		{
			return null;
		}

		public bool AnyDirtyIgnorePlayerData()
		{
			return false;
		}

		public void AddSaveOrder(string fileName, object objectToSave)
		{
		}

		[AsyncStateMachine(typeof(_003CWaitSavingCompleted_003Ed__26))]
		public UniTask WaitSavingCompleted()
		{
			return default;
		}

		public void DeleteSave(string fileName)
		{
		}

		public static void ForceDeleteSave(string fileName)
		{
		}

		private PlayerInfo LoadLocalSave()
		{
			return null;
		}

		private PlayerInfo LoadLocalSave(LocalSaveService service)
		{
			return null;
		}

		public void ContinueSaveLocal(bool asyn)
		{
		}

		public void DeleteLocalSaves()
		{
		}

		public void CacheLocalSaveAsGuest()
		{
		}

		private bool CopyLocalSaveFilesToGuest()
		{
			return false;
		}

		public void TrySaveToCloud(bool forceAll = false)
		{
		}

		private void SaveToCloud(bool forceAll)
		{
		}

		[AsyncStateMachine(typeof(_003CConfirmFullCloudSyncAsync_003Ed__39))]
		private UniTaskVoid ConfirmFullCloudSyncAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoadCloudSaves_003Ed__40))]
		public UniTask LoadCloudSaves()
		{
			return default;
		}
	}
}
