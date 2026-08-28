using System.Collections.Generic;
using Game.Combat;
using UnityEngine;
using UnityEngine.Events;

namespace Game.GearUpgrade
{
	public class GearUICollectionGroup : MonoBehaviour
	{
		[SerializeField]
		private List<GearUICollectionItem> _items;

		[Header("Events")]
		public UnityEvent OnCollectionClaimedEvent;

		private void Start()
		{
		}

		public void UpdateInfo(List<GearData> gearDatas)
		{
		}
	}
}
