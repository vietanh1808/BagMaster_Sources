using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ProjectileController : MonoBehaviour, IUpdater
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDelayEnableBehaviours_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ProjectileController _003C_003E4__this;

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
		private ProjectilePositionAnchor _startPositionAnchor;

		[SerializeField]
		private ProjectileAngleAnchor _startAngleAnchor;

		[SerializeField]
		private SpriteRenderer _projectileRenderer;

		[SerializeField]
		private float _maxLifeTime;

		[SerializeField]
		private bool _endWhenEndCombat;

		[SerializeField]
		private bool _childMuzzle;

		[Header("Runtime")]
		public Vector2 PositionOffset;

		public float RotationOffset;

		public Vector3 TargetPositionOffset;

		public float Delay;

		private ProjectileBehaviour[] _behaviours;

		private float _endTime;

		private ProjectileEvents _events;

		private Transform _targetTransform;

		private bool _invokedEnd;

		private SimpleSkill _registeredSkill;

		private CancellationTokenSource _cancellentoken;

		[field: Header("Pool Config")]
		[field: SerializeField]
		public int InitialPoolObj { get; private set; }

		[field: SerializeField]
		public int MaxPoolObj { get; private set; }

		public ProjectileOptions Options { get; set; }

		public Transform Target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float MaxLifeTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float EndTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		void IUpdater.CustomUpdate(float dt)
		{
		}

		public void Setup(ProjectileEvents events)
		{
		}

		[AsyncStateMachine(typeof(_003CDelayEnableBehaviours_003Ed__43))]
		private UniTask DelayEnableBehaviours()
		{
			return default;
		}

		public void SetAtkSprite(Sprite sprite)
		{
		}

		private void SetupTargetTransform()
		{
		}

		private void UpdateStartPosition()
		{
		}

		public void UpdateStartAngle()
		{
		}

		public void ResetLifeTime()
		{
		}

		private void InvokeEnd()
		{
		}

		private void CancelToken()
		{
		}

		private void RegisterSkill()
		{
		}

		private void UnregisterSkill()
		{
		}
	}
}
