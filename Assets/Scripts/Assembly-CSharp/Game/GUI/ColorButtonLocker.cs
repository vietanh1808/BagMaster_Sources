using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.GUI
{
	public class ColorButtonLocker : ButtonLocker
	{
		private const string TargetGroup = "Target to dim on lock";

		[SerializeField]
		private Color _dimColor;

		[SerializeField]
		private Image[] _images;

		[SerializeField]
		private TMP_Text[] _texts;

		private readonly Dictionary<Component, Color> _originalColorMap;

		private bool _isLocked;

		public override bool IsLocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void UpdateDecorators(bool isLocked)
		{
		}

		private void Start()
		{
		}

		private void TryInit()
		{
		}
	}
}
