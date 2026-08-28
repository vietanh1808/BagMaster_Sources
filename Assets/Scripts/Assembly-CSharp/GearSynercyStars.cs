using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Combat;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using UnityEngine;

public class GearSynercyStars : MonoBehaviour
{
	public class BuffData
	{
		public Vector2Int RealtimeGridPosition;

		public Gear HoverGear;

		public bool AllowShowStar;

		public bool PreviewStar;

		public readonly BuffSource BuffSource;

		public readonly SpriteRenderer Star;

		public readonly Vector2Int GridPosition;

		private readonly Gear _ownerGear;

		private readonly Sprite _activeStarSprite;

		private readonly Sprite _inactiveStarSprite;

		private readonly AutoActiveFalse _starVisibler;

		private GameObject _currentVfx;

		private bool _isActive;

		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TargetFinderGearNearby NearbyFinder => null;

		public BuffData(Gear ownerGear, SpriteRenderer starRenderer, Sprite activeStarSprite, Sprite inactiveStarSprite, Vector2Int gridPosition, BuffSource buffSource)
		{
		}

		public bool HasEffect()
		{
			return false;
		}

		public void Show()
		{
		}

		public void RemoveVfx()
		{
		}

		private void VerifyCurrentVfx()
		{
		}

		public void UpdateStarVisible()
		{
		}
	}

	public class BuffSource
	{
		public ActivateBaseOnGearNearbyComponent Component;

		public HashSet<Vector2Int> StarPositions;
	}

	[CompilerGenerated]
	private sealed class _003CTriggerHidingEffectOfOtherGears_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public GearSynercyStars _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CTriggerHidingEffectOfOtherGears_003Ed__53(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private Gear _gear;

	[SerializeField]
	private SpriteRenderer _starGameObject;

	[SerializeField]
	private Sprite[] _startActiveSprites;

	[SerializeField]
	private Sprite[] _startInactiveSprites;

	[SerializeField]
	private float _starScale;

	[SerializeField]
	private MMObjectPooler _synercyBuffVfxPool;

	[SerializeField]
	private MMObjectPooler _synercyBuffDropVfxPool;

	[SerializeField]
	private MMF_Player _feedbackWhenStarDrop;

	[Header("Runtime")]
	public bool LockShowSynergy;

	public bool InShowingSynercy;

	[SerializeField]
	private List<GearSynercyHint> _potentialGear;

	private GearSynercyHint _gearSynercyHint;

	private List<BuffData> _buffDatas;

	private List<BuffSource> _buffSources;

	private List<GearSynercyHint> _inSynercyGears;

	private bool _isShow;

	private bool _isShowStars;

	private Gear _relativeGear;

	private int _initialSortingOrder;

	private BagContentDropArea _bagDropArea;

	public IReadOnlyList<BuffData> BuffDatas => null;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void Build()
	{
	}

	private void AddBuffSource(ActivateBaseOnGearNearbyComponent nearbyComponent, List<Vector2Int> positions)
	{
	}

	private void LateUpdate()
	{
	}

	public bool CanSynercy(Gear checkGear)
	{
		return false;
	}

	public bool InSynercy(Gear checkGear)
	{
		return false;
	}

	private void ShowAreaEffected()
	{
	}

	private bool ShouldShowSynercyHighlight(BuffData buffData)
	{
		return false;
	}

	private void UpdateBuffDataHoverGear(BuffData buffData)
	{
	}

	public void Fetch()
	{
	}

	private void AdjustStarTransform(BuffData buffData, Vector2 containerScale, float starScale, Vector3 pivot, bool fitToGrid)
	{
	}

	private bool CheckStarGear(BuffData buffData, Vector2Int anchorPoint)
	{
		return false;
	}

	private bool CheckGear(BuffData buffData, out Gear gear)
	{
		gear = null;
		return false;
	}

	public void ShowStars(Vector3 pivot, float space = 1f, float scale = 1f, int sortinglayerOrder = 0)
	{
	}

	public void HideStars()
	{
	}

	private bool HasGearInGrid(Vector2Int gridPosition, out IBagGridItem item)
	{
		item = null;
		return false;
	}

	private void OnSelected(bool selected)
	{
	}

	public void ShowEffect()
	{
	}

	public void HintGearColors(bool isBuffSelf)
	{
	}

	private void UpdatePotentialGearBuffColor(bool isBuffSelf)
	{
	}

	private void CheckActiveGearMark()
	{
	}

	private void UpdateSynercyIfNoHasSynercySkill()
	{
	}

	public void ClearEffects()
	{
	}

	private void ClearGearsInSynercyEffect()
	{
	}

	private void ClearPotentialGearHint()
	{
	}

	private void RevertGearColors()
	{
	}

	public void HideEffectIfShowed()
	{
	}

	public void HideEffect()
	{
	}

	[IteratorStateMachine(typeof(_003CTriggerHidingEffectOfOtherGears_003Ed__53))]
	private IEnumerator TriggerHidingEffectOfOtherGears(float delay)
	{
		return null;
	}
}
