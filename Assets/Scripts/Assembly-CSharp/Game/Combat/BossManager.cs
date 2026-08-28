using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class BossManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWinGame_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BossManager _003C_003E4__this;

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
		private GameObject _bossUiPrefab;

		[SerializeField]
		private Transform _bossUiContainer;

		[SerializeField]
		private MMF_Player _bossAppearFeedback;

		[SerializeField]
		private GameObject _blowingKillVfx;

		[SerializeField]
		private Vector3 _blowingKillOffset;

		[Header("Runtime")]
		[SerializeField]
		private List<EnemyController> _bosses;

		private Dictionary<EnemyController, GameObject> _bossesDict;

		private Queue<EnemyController> _bossQueue;

		public static BossManager Instance { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void AddBoss(EnemyController enemyController)
		{
		}

		public void CreateBossUi(EnemyController enemyController)
		{
		}

		public bool AllBossDefeated()
		{
			return false;
		}

		private void SetConfig(EnemyController enemyController)
		{
		}

		private void OnBossDefeated(EnemyController enemyController)
		{
		}

		[AsyncStateMachine(typeof(_003CWinGame_003Ed__20))]
		private UniTaskVoid WinGame()
		{
			return default;
		}

		private void PlayBossDeathFlick(EnemyController enemyController)
		{
		}

		private void CheckTutorialBoss(EnemyController enemyController)
		{
		}

		private void TestBossFlick()
		{
		}
	}
}
