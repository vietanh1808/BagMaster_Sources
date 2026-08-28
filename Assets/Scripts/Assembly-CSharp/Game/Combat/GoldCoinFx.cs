using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Game.CodedAnimation;
using UnityEngine;

namespace Game.Combat
{
	public class GoldCoinFx : MonoBehaviour
	{
		[Serializable]
		public struct FirstSpawnAnimOptions
		{
			public float jumpPower;

			public float jumpDuration;

			public Ease jumpEase;

			public float scaleDuration;

			public Ease scaleEase;

			public Vector2 randomXRange;

			public Vector2 randomYRange;

			public Vector2 jumpRange;
		}

		[Serializable]
		public struct FlyAnimOptions
		{
			public Vector2 randomSpeed;

			public EaseOrAnimationCurve flyEase;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlay_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GoldCoinFx _003C_003E4__this;

			private Vector3 _003CtargetPosition2_003E5__2;

			private Vector3 _003CtargetPosition3_003E5__3;

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

		private static GoldCoinFx prefab;

		[SerializeField]
		private int delayToFly;

		[SerializeField]
		private SpriteRenderer renderer;

		[SerializeField]
		private Transform rendererHolder;

		private Vector3 destination;

		[SerializeField]
		private FirstSpawnAnimOptions spawnAnimOptions;

		[SerializeField]
		private FlyAnimOptions flyAnimOptions;

		private Action<GoldCoinFx> onFlyFinishedEvent;

		private CancellationTokenSource cts;

		private bool isFlying;

		public static List<GoldCoinFx> Items { get; private set; }

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CPlay_003Ed__17))]
		public void Play()
		{
		}

		public static void Clean()
		{
		}

		public void Clear()
		{
		}

		public void Fly()
		{
		}

		public void SetLayerOvertop()
		{
		}

		private void OnEnd()
		{
		}

		public static void Create(Vector2 around, Vector3 destination, Action<GoldCoinFx> onFlyFinished = null)
		{
		}
	}
}
