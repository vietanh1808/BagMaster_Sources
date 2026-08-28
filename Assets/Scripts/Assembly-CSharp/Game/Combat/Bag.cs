using System;
using System.Collections.Generic;
using Game.CodedAnimation;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class Bag : MonoBehaviour
	{
		public Camera UICamera;

		public BagContentDropArea ContentDropArea;

		[Header("Slot configs")]
		[SerializeField]
		private Square _squarePrefab;

		[SerializeField]
		private Transform _content;

		[SerializeField]
		private Transform _gearContainer;

		[Header("Feedbacks")]
		public MMF_Player ReceivedBuffFeedeback;

		public EaseOrAnimationCurve NewSlotAppearScaleEase;

		[Header("Events")]
		public UnityEvent<Vector2Int, Square> OnAddSquareEvent;

		public UnityEvent OnInitializedEvent;

		[SerializeField]
		private bool _isDebug;

		[SerializeField]
		private GameObject _layout;

		[Obsolete("Use Globals.GetPlayer()")]
		public static Bag Instance { get; private set; }

		public bool Ready { get; private set; }

		public Dictionary<Vector2Int, Square> Squares { get; private set; }

		public Transform GearContainer => null;

		public Vector3 CenterPosition => default;

		public void SetLayout(GameObject layout)
		{
		}

		public void AddSquare(Vector2Int position)
		{
		}

		public void Initialize()
		{
		}

		public Square AddValidSquare(Vector2Int position)
		{
			return null;
		}

		public Square GetHighestSquare()
		{
			return null;
		}

		public void FeedbackReceivedBuff(float intensity = 1f)
		{
		}

		public void CloneFrom(Bag source, Unit destinationOwner)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
