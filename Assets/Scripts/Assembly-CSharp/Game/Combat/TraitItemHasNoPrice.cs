using System;
using System.Collections.Generic;
using Game.Constant;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class TraitItemHasNoPrice : TraitItem
	{
		[SerializeField]
		private List<GameObject> _disableObject;

		[SerializeField]
		private List<GameObject> _enableObject;

		[SerializeField]
		private Button _getBtn;

		[Header("Color System")]
		[SerializeField]
		private List<Image> _colorTargets;

		[Tooltip("Array of 5 colors: [0]=Common, [1]=UnCommon, [2]=Rare, [3]=Epic, [4]=Legend")]
		[SerializeField]
		private Color[] _rarityColors;

		private List<Color> _originalColors;

		private int _currentRarityIndex;

		[SerializeField]
		private Image _mainFrameImg;

		private Vector3 originalScale;

		[SerializeField]
		private BuffRarityProfile _buffRarityProfile;

		[SerializeField]
		private TextMeshProUGUI _buffRarityText;

		[SerializeField]
		private bool _showLogs;

		public Action TriggerLegendVFXAction;

		private void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnGet()
		{
		}

		public override void Initialize(BuffData buffData, Unit player, float delayAppear, bool isRecommended)
		{
		}

		public override void RequestChangeFrame(Rarity rarity)
		{
		}

		public void ChangeFrame(string frameKey)
		{
		}

		public void CheckSkipRare()
		{
		}

		public void TriggerLegendVFX()
		{
		}

		private void ApplyRarityColor(int rarityIndex)
		{
		}

		private void ApplyRarityColorImmediate(int rarityIndex)
		{
		}

		public void Reset()
		{
		}
	}
}
