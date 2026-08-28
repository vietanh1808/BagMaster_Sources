using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class BenchDropArea : DropArea
	{
		[SerializeField]
		private Vector2 _placePositionOffset;

		[SerializeField]
		private Sprite[] _benchSlotSprites;

		[SerializeField]
		private SpriteRenderer _benchSlotRenderer;

		[SerializeField]
		private DropArea _counterDropArea;

		[SerializeField]
		private MMF_Player _gearPlaceFeedback;

		[SerializeField]
		private float _scaleGearCollider;

		[SerializeField]
		private float _gearMovementSpeed;

		[SerializeField]
		private MMF_Player _clickShowTooltipFeedback;

		[Header("Events")]
		public UnityEvent OnChargeUsedEvent;

		public UnityEvent<int> OnChargesChangedEvent;

		public UnityEvent<Gear> OnGearPlacedEvent;

		public UnityEvent OnNoChargesClickedEvent;

		public UnityEvent<Gear> OnGearLeaveEvent;

		public UnityEvent<Gear> OnConnectionBrokenEvent;

		[Header("Runtime")]
		[SerializeField]
		private int _charges;

		[SerializeField]
		private Gear _current;

		public bool LockMerge;

		public bool UnlimitedUse;

		private Gear _previousWaveGear;

		private bool _hasChanges;

		private DragDropHandler _benchTarget;

		public bool IsEmpty => false;

		public Gear Current => null;

		public Gear PreviousGear => null;

		public int Charges => 0;

		public bool HasChanges => false;

		private void Start()
		{
		}

		private void OnStartWave()
		{
		}

		public override bool CanAccept(DragDropHandler dragDropHandler)
		{
			return false;
		}

		public override void Drop(DragDropHandler dragDropHandler)
		{
		}

		public override void OnHover(DragDropHandler dragDropHandler)
		{
		}

		public override void OnExit(DragDropHandler dragDropHandler)
		{
		}

		public override void Remove(DragDropHandler dragDropHandler)
		{
		}

		public override void OnClick()
		{
		}

		public void SetSprites(Sprite[] sprites)
		{
		}

		public void UseCharge()
		{
		}

		public void RestoreCharge(int value)
		{
		}

		public void SetCharges(int value)
		{
		}

		private Vector3 CalculatePlacePosition(Gear gear)
		{
			return default;
		}

		private void SetPreviousGear(Gear gear)
		{
		}

		private void OnPreivousGearDestroyed()
		{
		}

		public void ResetBenchTarget()
		{
		}

		public void InitPreviousGear()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
