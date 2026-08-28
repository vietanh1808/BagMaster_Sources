using System.Collections.Generic;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class BagGeneralStats : MonoBehaviour
	{
		public class SynercyTextData
		{
			public string Content;
		}

		[SerializeField]
		private TextMeshProUGUI _damagePerSecondText;

		[SerializeField]
		private TextMeshProUGUI _damageChangesText;

		[SerializeField]
		private MMF_Player _damageIncreaseFeedback;

		[SerializeField]
		private MMF_Player _damageDecreaseFeedback;

		[Space(10f)]
		[SerializeField]
		private TextMeshProUGUI _healPerSecondText;

		[SerializeField]
		private TextMeshProUGUI _healChangesText;

		[SerializeField]
		private MMF_Player _healIncreaseFeedback;

		[SerializeField]
		private MMF_Player _healDecreaseFeedback;

		[Space(10f)]
		[SerializeField]
		private TextMeshProUGUI _shieldPerSecondText;

		[SerializeField]
		private TextMeshProUGUI _shieldChangesText;

		[SerializeField]
		private MMF_Player _shiedIncreaseFeedback;

		[SerializeField]
		private MMF_Player _shiedDecreaseFeedback;

		[Space(10f)]
		[SerializeField]
		private float _delayShowFeedbackIfHasBuff;

		private float _currentDps;

		private float _currentHps;

		private float _currentSps;

		private Unit _player;

		private int _damageChangeState;

		private int _healChangeState;

		private int _shieldChangeState;

		private Queue<SynercyTextData> _synercyTextDatas;

		private CanvasGroup _canvasGroup;

		private bool _hasCanvasGroup;

		public string PlayerCpText => null;

		public float PlayerCp => 0f;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void AddSynercyText(string content)
		{
		}

		public void ClearSynercyText()
		{
		}

		private void PlaySynercyTexts(GameObject source, MMF_Player feedback)
		{
		}

		public void Compare(IReadOnlyCollection<IBagGridItem> items)
		{
		}

		public void Fetch(IReadOnlyCollection<IBagGridItem> items)
		{
		}

		public static string FormatStatValue(float value, bool min1 = false)
		{
			return null;
		}

		private int Compare(float a, float b)
		{
			return 0;
		}

		private float Sub(float a, float b)
		{
			return 0f;
		}

		public static void CalculatePs(IEnumerable<IBagGridItem> items, out float damagePerSecond, out float healPerSecond, out float shieldPerSecond)
		{
			damagePerSecond = default;
			healPerSecond = default;
			shieldPerSecond = default;
		}

		private void UpdateChangesText(TextMeshProUGUI changeText, TextMeshProUGUI mainText, float changesValue)
		{
		}
	}
}
