using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class CoinFX : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFly_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CoinFX _003C_003E4__this;

			private float _003Cduration_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private struct _003CSetLayerOvertop_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CoinFX _003C_003E4__this;

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
		private float tweenTimePerUnit;

		[SerializeField]
		private float delay;

		[SerializeField]
		private float scaleDestination;

		[SerializeField]
		private float scaleDuration;

		[SerializeField]
		private Ease scaleEase;

		[Header("Combat variant")]
		[SerializeField]
		private float delayUpdateLayer;

		[SerializeField]
		private Vector2 randomXRange;

		[SerializeField]
		private float moveXDuration;

		[SerializeField]
		private Ease moveXEase;

		[SerializeField]
		private Vector2 randomYRange;

		[SerializeField]
		private float moveYDuration;

		[SerializeField]
		private AnimationCurve moveYEase;

		private CancellationTokenSource _cancelSource;

		private Action _onFlyFinished;

		private Vector3 _destination;

		private void Start()
		{
		}

		private void OnWaveEnded(PlayerActionEventData eventData)
		{
		}

		private void OnDisable()
		{
		}

		private void Play()
		{
		}

		private void PlayCombatVariant()
		{
		}

		[AsyncStateMachine(typeof(_003CFly_003Ed__20))]
		private UniTask Fly()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSetLayerOvertop_003Ed__21))]
		public UniTask SetLayerOvertop()
		{
			return default;
		}

		public static void Create(Vector2 around, Vector3 destination, Action onFlyFinished = null)
		{
		}

		public static void CreateCombatVariant(Vector2 around, Vector3 destination, Action onFlyFinished = null)
		{
		}

		public static void CreateCombatFlyItem(string prefabName, Vector2 around, Vector3 destination, Action onFlyFinished = null)
		{
		}

		public static void CreateGoldCaveCoin(Vector2 around, Vector3 destination, Action onFlyFinished = null)
		{
		}

		[Obsolete]
		public static void CreateGoldCaveCoinCombatVariant(Vector2 around, Vector3 destination, Action onFlyFinished = null)
		{
		}
	}
}
