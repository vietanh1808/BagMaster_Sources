using Game.Tools;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class StatusImageListView : MonoBehaviour
	{
		[SerializeField]
		private Image _imagePrefab;

		[SerializeField]
		private RectTransform _imageContainer;

		[SerializeField]
		private StatusManager _statusManager;

		[SerializeField]
		private StatusIconProfiles _statusIconProfiles;

		private SimpleObjectPool<Image> _imagePool;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnStatusAppied(StatusData statusData)
		{
		}

		private void OnStatusRemoved(StatusData statusData)
		{
		}

		private void Refresh()
		{
		}

		private void CreateIcon(StatusData statusData)
		{
		}

		private void CreateIcon(Sprite icon)
		{
		}
	}
}
