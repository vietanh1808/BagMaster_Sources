using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class EventDungeonInfoRewardViewItem : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private TMP_Text textAmount;

		public void SetData(ResourceRewardData data)
		{
		}
	}
}
