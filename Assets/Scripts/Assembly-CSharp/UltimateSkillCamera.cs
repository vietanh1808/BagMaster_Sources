using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using MoreMountains.Tools;
using UnityEngine;

public class UltimateSkillCamera : MonoBehaviour, MMEventListener<UltimateSkillCastedEvent>, MMEventListenerBase
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDOAnimation_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public UltimateSkillCamera _003C_003E4__this;

		public CancellationToken cancellationToken;

		private Vector3 _003CinitialPosition_003E5__2;

		private float _003CinitialOrthor_003E5__3;

		private CameraFixWidth _003CcameraFixWidth_003E5__4;

		private DOTweenAsyncExtensions.TweenAwaiter _003C_003Eu__1;

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

	public Camera Camera;

	public Transform ZoomPosition;

	public float ZoomOrthorValue;

	[Header("Animation")]
	[SerializeField]
	private float _zoomInMovementDuration;

	[SerializeField]
	private float _zoomInDuration;

	[SerializeField]
	private float _zoomOutMovementDuration;

	[SerializeField]
	private float _zoomOutDuration;

	[SerializeField]
	private float _maintainDuration;

	[Header("Runtime")]
	[SerializeField]
	private bool _inAnimation;

	[SerializeField]
	private float _endTime;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnMMEvent(UltimateSkillCastedEvent eventType)
	{
	}

	[AsyncStateMachine(typeof(_003CDOAnimation_003Ed__13))]
	private UniTaskVoid DOAnimation(CancellationToken cancellationToken)
	{
		return default;
	}

	public void InvokeTest()
	{
	}
}
