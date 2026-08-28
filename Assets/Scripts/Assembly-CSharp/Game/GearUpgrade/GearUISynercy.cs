using Game.AssetManager;
using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class GearUISynercy : MonoBehaviour
	{
		[SerializeField]
		private Image _synercyImage;

		[SerializeField]
		private TextMeshProUGUI _synercyText;

		[SerializeField]
		private GameObject _noSynergyBanner;

		private AsyncOperationHandle<Sprite> _loadPreviewHandle;

		private SpriteAddressable _gearSynercySpriteLoader;

		private void OnDestroy()
		{
		}

		public void UpdateInfo(GearData gearData)
		{
		}

		private void LoadSynercyImage(string assetName)
		{
		}

		private void OnSynercySpriteLoaded(Sprite sprite)
		{
		}
	}
}
