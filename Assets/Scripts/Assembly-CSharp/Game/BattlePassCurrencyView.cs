using BattlePass.Model;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class BattlePassCurrencyView : MonoBehaviour, IResourceReturnValueUI
	{
		[SerializeField]
		private GameObject levelObject;

		[SerializeField]
		private GameObject levelMaxObject;

		[SerializeField]
		private TextMeshProUGUI textLevel;

		[SerializeField]
		private Image imageFill;

		[SerializeField]
		private TextMeshProUGUI textProgress;

		private int lastPoint;

		private Tweener tweener;

		private Tweener tweener1;

		public bool shouldCompareLastPoint;

		public void SetDisplayValueOffset(int value)
		{
		}

		public void ForceReset()
		{
		}

		public static void ForceReset(GameObject levelObject, GameObject levelMaxObject, TextMeshProUGUI textProgress, TextMeshProUGUI textLevel, Image imageFill)
		{
		}

		public static void HandleMaxLevelCase(BattlePassPayload payload, GameObject levelObject, GameObject levelMaxObject, TextMeshProUGUI textProgress, Image imageFill)
		{
		}

		public static void HandMaxExtraLevelCast(BattlePassPayload payload, GameObject levelObject, GameObject levelMaxObject, TextMeshProUGUI textProgress, TextMeshProUGUI textLevel, Image imageFill)
		{
		}
	}
}
