using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class KillingBlow : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAnimate_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public KillingBlow _003C_003E4__this;

			public Color backgroundColor;

			public Color flashColor;

			public CharacterModel target;

			public float duration;

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
		private SpriteRenderer _background;

		[SerializeField]
		private Animator _animator;

		[Header("Runtime")]
		[SerializeField]
		private string _originalSortingLayerName;

		[SerializeField]
		private int _originalSortingOrder;

		[SerializeField]
		private CharacterModel _model;

		[SerializeField]
		private Color _flashColor;

		[AsyncStateMachine(typeof(_003CAnimate_003Ed__6))]
		public UniTask Animate(CharacterModel target, float duration, Color flashColor, Color backgroundColor)
		{
			return default;
		}

		public void FadeOut()
		{
		}

		public void ApplyFlash()
		{
		}

		public void Revert()
		{
		}

		public void End()
		{
		}
	}
}
