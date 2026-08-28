using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MoreMountains.Tools;
using UnityEngine;

namespace Game.Testing
{
	public class SaveLoadProgress : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SaveLoadProgress _003C_003E4__this;

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

		private static SaveLoadProgress _instance;

		[Header("Runtime")]
		[SerializeField]
		private TestProfileData _testProfileData;

		private MMSaveLoadManagerMethodJson _saveMethod;

		private IDisposable _disposable;

		[AsyncStateMachine(typeof(_003CStart_003Ed__4))]
		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void StartRecord()
		{
		}

		private void StopRecord()
		{
		}

		private void AddProfile()
		{
		}

		public void SaveTestProfile(TestProfileData profileData)
		{
		}

		public static TestProfileData LoadTestProfile(string profileName)
		{
			return null;
		}

		public static string GetBaseFolder()
		{
			return null;
		}

		public static string GetUniqueFileName(string path)
		{
			return null;
		}
	}
}
