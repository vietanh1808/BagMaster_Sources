using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Game.CodedAnimation;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class ModelScaleStatApplier : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTestScale_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ModelScaleStatApplier _003C_003E4__this;

			public float value;

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
		private Transform _model;

		[SerializeField]
		private bool _autoAccquireModelFromUnit;

		[Header("Scale up")]
		[SerializeField]
		private float _scaleUpDuration;

		[SerializeField]
		private EaseOrAnimationCurve _scaleUpEase;

		[Header("Scale down")]
		[SerializeField]
		private float _scaleDownDuration;

		[SerializeField]
		private EaseOrAnimationCurve _scaleDownEase;

		[Header("Events")]
		public UnityEvent OnScaleUpEvent;

		public UnityEvent OnScaleDownEvent;

		private Stat _modelScaleStat;

		private Tween _scaleTween;

		private float _initialScale;

		private float _latestScale;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnScaleChange(float scaleStat)
		{
		}

		private void CancelTween()
		{
		}

		[AsyncStateMachine(typeof(_003CTestScale_003Ed__16))]
		private void TestScale(float value)
		{
		}
	}
}
