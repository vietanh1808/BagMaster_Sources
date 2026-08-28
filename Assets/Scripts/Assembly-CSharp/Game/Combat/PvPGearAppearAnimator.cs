using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.CodedAnimation;
using UnityEngine;

namespace Game.Combat
{
	public class PvPGearAppearAnimator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAppear_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGearAppearAnimator _003C_003E4__this;

			public string icon;

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
		private struct _003CDoFly_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGearAppearAnimator _003C_003E4__this;

			public string icon;

			public SpriteRenderer target;

			private GameObject _003CflyGearObject_003E5__2;

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
		private struct _003CPlay_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGearAppearAnimator _003C_003E4__this;

			public string icon;

			public SpriteRenderer target1;

			public SpriteRenderer target2;

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
		private struct _003CPlay_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGearAppearAnimator _003C_003E4__this;

			public string icon;

			public SpriteRenderer target;

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
		private SpriteRenderer _gearIcon;

		[SerializeField]
		private SpriteRenderer _glow;

		[SerializeField]
		private SpriteRenderer _flyGearPrefab;

		[Header("Appear Animation")]
		[SerializeField]
		private EaseOrAnimationCurve _appearAnimationCurve;

		[SerializeField]
		private float _appearAnimationDuration;

		[SerializeField]
		private float _flyGearAnimationDuration;

		[SerializeField]
		private float _flyGearAnimationHeight;

		[SerializeField]
		private float _flyGearScaleToValue;

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CPlay_003Ed__9))]
		public UniTask Play(string icon, SpriteRenderer target)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CPlay_003Ed__10))]
		public UniTask Play(string icon, SpriteRenderer target1, SpriteRenderer target2)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CAppear_003Ed__11))]
		private UniTask Appear(string icon)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CDoFly_003Ed__12))]
		private UniTask DoFly(string icon, SpriteRenderer target)
		{
			return default;
		}
	}
}
