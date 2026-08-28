using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class EndWaveFeedback : MonoBehaviour
	{
		[SerializeField]
		private GameObject _lootBox;

		[SerializeField]
		private MMF_Player _feedback;

		[SerializeField]
		private bool _includeFinalWave;

		[Header("By Rarities")]
		[SerializeField]
		private GameObject _commonChest;

		[SerializeField]
		private GameObject _uncommonChest;

		[SerializeField]
		private GameObject _rareChest;

		[SerializeField]
		private GameObject _epicChest;

		[SerializeField]
		private GameObject _legendaryChest;

		private void Start()
		{
		}

		public void OnPlayerAction(PlayerActionEventData eventData)
		{
		}
	}
}
