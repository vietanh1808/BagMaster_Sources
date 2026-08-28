using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class PlayerUnit : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAutoNextWave_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PlayerUnit _003C_003E4__this;

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
		private struct _003CDoDeath_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PlayerUnit _003C_003E4__this;

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
		private struct _003CKickOut_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PlayerUnit _003C_003E4__this;

			public string defeatPage;

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

		[SerializeField]
		private GameObject _revivePopup;

		[SerializeField]
		private float _delayWhenDeath;

		[SerializeField]
		private KillingBlow _killingBlowPrefab;

		[SerializeField]
		private Transform _killingBlowPosition;

		[SerializeField]
		private MMF_Player _kickOutFeedback;

		[SerializeField]
		private Transform _kickOutTransform;

		[SerializeField]
		private float _kickOutDirection;

		[SerializeField]
		private bool _autoInitializeOnAwake;

		[SerializeField]
		private CharacterSkinEquipmentBinder _skinEquipmentBinder;

		[Header("Runtime")]
		[SerializeField]
		private int _reviveCount;

		[SerializeField]
		private bool doNotLoadSave;

		private KillingBlow _killingBowFx;

		private bool _initialized;

		private Vector3? _preKickOutPosition;

		private Quaternion? _preKickOutRotation;

		private static int MaxReviveCount => 0;

		public Unit Unit { get; private set; }

		public IStatHolder StatHolder { get; private set; }

		public int Id => 0;

		public CharacterSkinEquipmentBinder SkinEquipmentBinder => null;

		public int RevivedCount => 0;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void Initialize()
		{
		}

		private PlayerInfo GetPlayerInfo()
		{
			return null;
		}

		private void OnDie(Health health)
		{
		}

		[AsyncStateMachine(typeof(_003CAutoNextWave_003Ed__36))]
		private UniTask AutoNextWave()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CDoDeath_003Ed__37))]
		private UniTask DoDeath()
		{
			return default;
		}

		private void PlayKillingBlow()
		{
		}

		public void FadeKillingBow()
		{
		}

		[AsyncStateMachine(typeof(_003CKickOut_003Ed__40))]
		public UniTask KickOut(string defeatPage)
		{
			return default;
		}

		protected virtual string GetRevivePopupPage()
		{
			return null;
		}

		protected virtual string GetDefeatPage()
		{
			return null;
		}

		public void Revive()
		{
		}

		private void ResetPosition()
		{
		}

		private void OnRevive(Health health)
		{
		}

		public void SetId(int id)
		{
		}
	}
}
