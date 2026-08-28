using UnityEngine;

namespace Game
{
	public class TalentCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

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

		private void SetDirty(int type)
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
