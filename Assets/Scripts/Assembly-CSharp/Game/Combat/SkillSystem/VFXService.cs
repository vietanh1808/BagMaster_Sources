using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.AssetManager;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class VFXService : SafeDisposeable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateVfx_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public VFXService _003C_003E4__this;

			public Action<GameObject> onVfxCreated;

			private Vector3 _003Cposition_003E5__2;

			private Quaternion _003Crotation_003E5__3;

			private bool _003Cchanges_003E5__4;

			private Vector3 _003Cscale_003E5__5;

			private Transform _003Cparent_003E5__6;

			private string _003Cpath_003E5__7;

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

		public VFXServiceData Data;

		private readonly PrefabAddressable _prefabLoader;

		private readonly VfxPosition _positionType;

		private readonly Vector2 _offset;

		private readonly VfxRotation _rotationType;

		private readonly float _delayAppear;

		private readonly bool _parentProjectile;

		private readonly bool _autoDestroy;

		private bool _preloaderLoaded;

		private float _signDirection;

		private List<GameObject> _activeVfxs;

		private CancellationTokenSource _cancellation;

		public VFXService(PrefabAddressable prefabLoader, VfxPosition positionType, Vector2 offset, VfxRotation rotationType, float delayAppear, bool parentProjectile, bool autoDestroy = true)
		{
		}

		[AsyncStateMachine(typeof(_003CCreateVfx_003Ed__13))]
		public UniTaskVoid CreateVfx(Action<GameObject> onVfxCreated = null)
		{
			return default;
		}

		private static float GetUnitDirection(Transform caster)
		{
			return 0f;
		}

		private bool AutoDestroyTimeline(GameObject instance)
		{
			return false;
		}

		private void AutoDestroyParticleSystem(GameObject instance)
		{
		}

		public void StopVfx()
		{
		}

		public Vector3 GetVfxPosition()
		{
			return default;
		}

		public Quaternion GetRotation(out bool changes)
		{
			changes = default;
			return default;
		}

		protected override void DoDispose()
		{
		}
	}
}
