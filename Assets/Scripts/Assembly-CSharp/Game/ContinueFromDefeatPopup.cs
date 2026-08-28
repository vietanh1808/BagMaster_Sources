using System.Threading;
using Cysharp.Threading.Tasks;
using Game.Combat;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class ContinueFromDefeatPopup : MonoBehaviour
	{
		[SerializeField]
		private LocalizationParamsManager _title;

		[SerializeField]
		private LocalizationParamsManager _saveInfoText;

		[SerializeField]
		private Button _abandonButton;

		[SerializeField]
		private Button _continueWithAdsButton;

		[SerializeField]
		private UiBag _bag;

		[SerializeField]
		private SkillAcquiredPopup _skillAcquiredPanel;

		[SerializeField]
		[Header("Gem")]
		private Button _continueWithGemButton;

		[SerializeField]
		private TMP_Text _gemAmountText;

		[SerializeField]
		private ScrollRect _scoller;

		private readonly UniTaskCompletionSource<bool> _completeSource;

		private static ref readonly ContinueFromDefeatConfig Config
		{
			get
			{
				throw null;
			}
		}

		private void OnValidate()
		{
		}

		private void Start()
		{
		}

		private static void ShowSelectedBuffs(SkillAcquiredPopup skillAcquiredPanel, CombatSaveData saveData)
		{
		}

		private void InitAdsButton(Button button)
		{
		}

		private void InitGemButton(Button button)
		{
		}

		public UniTask<bool> AskToContinue(CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		private void Abandon()
		{
		}

		private void ContinueWithAds()
		{
		}

		private void OnAdsReward()
		{
		}

		private void ContinueWithGem()
		{
		}
	}
}
