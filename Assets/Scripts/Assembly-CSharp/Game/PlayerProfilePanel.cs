using TMPro;
using UnityEngine;

namespace Game
{
	public class PlayerProfilePanel : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _levelTxt;

		[SerializeField]
		private RectTransform _progressImg;

		[SerializeField]
		private float _progressImgSize0;

		[SerializeField]
		private float _progressImgSize1;

		private PlayerInfo PInfo => null;

		private PlayerExpData PED => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnExpChanged(int exp)
		{
		}

		private void UpdateLevelTxt(int exp)
		{
		}
	}
}
