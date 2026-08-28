using UnityEngine;

namespace Game.EquipmentSystem.Fuse
{
	public class ResultItem : EquipmentInfo
	{
		[SerializeField]
		private EquipmentInfoGeneralUI _generalUI;

		[SerializeField]
		private GameObject _highlight;

		public GameObject HightLight => null;

		protected override void UpdateInfo()
		{
		}

		public void ShowInfo()
		{
		}
	}
}
