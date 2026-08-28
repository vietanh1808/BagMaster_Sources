using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using UnityEngine;
using UnityEngine.Pool;

namespace Game
{
	public class UiBag : MonoBehaviour
	{
		[Serializable]
		private struct DamageDisplaySetting
		{
			public Sprite CupSprite;

			public Color Color;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateGear_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CombatSaveData saveData;

			public UiBag _003C_003E4__this;

			private PooledObject<List<CombatSaveData.GearData>> _003CpooledObject_003E5__2;

			private List<CombatSaveData.GearData> _003CbagGearDataList_003E5__3;

			private AsyncInstantiateOperation<UiGear>.Awaiter _003C_003Eu__1;

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
		private struct _003CCreateSquares_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CombatSaveData saveData;

			public UiBag _003C_003E4__this;

			private IntArray[] _003CunlockedSlots_003E5__2;

			private AsyncInstantiateOperation<RectTransform>.Awaiter _003C_003Eu__1;

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
		private struct _003CInit_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UiBag _003C_003E4__this;

			public CombatSaveData saveData;

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
		private RectTransform _squarePrefab;

		[SerializeField]
		private UiGear _gearPrefab;

		[SerializeField]
		private UiDamageBadge _damageBadgePrefab;

		[SerializeField]
		private RectTransform _topDecor;

		[SerializeField]
		private RectTransform _leftDecor;

		[SerializeField]
		private RectTransform _rightDecor;

		[SerializeField]
		private RectTransform _bottomDecor;

		[SerializeField]
		private float _spacing;

		[SerializeField]
		private RectTransform _gearContainer;

		[SerializeField]
		[Tooltip("Height of the extra shadow at the bottom of the bag container sprite")]
		private float _containerShadowHeight;

		[SerializeField]
		private RectOffset _padding;

		[SerializeField]
		private List<DamageDisplaySetting> _damageDisplaySettings;

		[SerializeField]
		[HideInInspector]
		private RectTransform _rectTransform;

		private Vector2 _maxGridPosition;

		private Vector2 _minGridPosition;

		private float SquareSize => 0f;

		private void OnValidate()
		{
		}

		private static void SetDecor(ref RectTransform target, string name, RectTransform value)
		{
		}

		[AsyncStateMachine(typeof(_003CInit_003Ed__20))]
		public UniTask Init(CombatSaveData saveData)
		{
			return default;
		}

		private Vector2 GetContentSize()
		{
			return default;
		}

		private Vector2 GetDecorSize()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CCreateSquares_003Ed__23))]
		private UniTask CreateSquares(CombatSaveData saveData)
		{
			return default;
		}

		public void AddSquare(in Vector2Int gridPosition)
		{
		}

		private void AddSquare(in Vector2Int gridPosition, RectTransform square)
		{
		}

		private void UpdateGridPositions(in Vector2Int gridPosition)
		{
		}

		[AsyncStateMachine(typeof(_003CCreateGear_003Ed__27))]
		private UniTask CreateGear(CombatSaveData saveData)
		{
			return default;
		}

		private void AddGear(UiGear uiGear, CombatSaveData.GearData saveData)
		{
		}

		public void AddGear(GearData gearData, in Vector2Int gridPosition)
		{
		}

		private void AddGear(UiGear uiGear, in Vector2Int gridPosition, GearGridData gridData)
		{
		}

		private void CreateDamageBadges(CombatSaveData saveData)
		{
		}

		public static bool IsActiveWeapon(CombatSaveData.GearData saveData)
		{
			return false;
		}

		private Vector2 GetAnchoredPosition(in Vector2 gridPosition)
		{
			return default;
		}
	}
}
