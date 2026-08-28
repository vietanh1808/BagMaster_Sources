using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class ExpandablePanel : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private RectTransform _panel;

		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private bool _startOn;

		[SerializeField]
		private float _heightOn;

		[SerializeField]
		private float _heightOff;

		[SerializeField]
		private float _tweenDuration;

		[SerializeField]
		private GameObject _onObject;

		[SerializeField]
		private GameObject _offObject;

		[SerializeField]
		private AdsRemovalButton _adsRemovalButton;

		[SerializeField]
		private FeatureUI[] _featureObjects;

		[SerializeField]
		private CanvasGroup[] _onCanvases;

		[SerializeField]
		private GameObject[] _onNotifications;

		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private VerticalLayoutGroup _verticalLayoutGroup;

		private bool _visible;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnToggle(bool value)
		{
		}

		private void OnFeatureUnlocked(string featureName)
		{
		}

		private void OnFeatureHided(FeatureUI featureUI)
		{
		}

		private void UpdatePanelHeight()
		{
		}

		private void TweenHeight(bool value)
		{
		}
	}
}
