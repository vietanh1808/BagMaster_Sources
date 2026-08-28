using System.Collections.Generic;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class SkillAcquiredPopup : MonoBehaviour
	{
		[SerializeField]
		private Transform _skillPanelContent;

		[SerializeField]
		private GameObject _skillAcquiredPrefab;

		[SerializeField]
		private GameObject _buffInfoPopup;

		[SerializeField]
		private MMF_Player _openBuffInfoPopupFeedback;

		private List<GameObject> _skillAcquiredList;

		public void ShowSkillAcquired(IReadOnlyCollection<BuffData> acquiredBuffs)
		{
		}

		public void OnEnable()
		{
		}

		private void ClearSkillAcquired()
		{
		}

		private void ShowBuffInfoPopup(GameObject skillItem, BuffData buffData)
		{
		}
	}
}
