using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class InventoryCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private Image _notificationImage;

		[SerializeField]
		private Sprite _fuseableSprite;

		[SerializeField]
		private Sprite _equipNotiSprite;

		[SerializeField]
		private Sprite _upgradeableSprite;

		[SerializeField]
		private Sprite _swapEquipNotiSprite;

		[SerializeField]
		private bool _hasEventListener;

		private bool _dirty;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnFeatureUnlocked(string featureName)
		{
		}

		private void SetDirty(OwnedItemEntity entity)
		{
		}

		private void SetDirty(OwnedResourceEntity entity, int arg2)
		{
		}

		private void Check()
		{
		}
	}
}
