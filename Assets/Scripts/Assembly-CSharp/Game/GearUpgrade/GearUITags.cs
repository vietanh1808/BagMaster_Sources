using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearUITags : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> _tagItems;

		[SerializeField]
		private float _tagTextPadding;

		public void UpdateInfo(Gear gear)
		{
		}

		public void UpdateInfo(GearData gearData)
		{
		}

		private void GenerateGearTag(IEnumerable<string> tags)
		{
		}
	}
}
