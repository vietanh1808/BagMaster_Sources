using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class BuffSelectionCounterUI : MonoBehaviour
	{
		[Header("UI References")]
		[Tooltip("Container chứa Horizontal Layout Group")]
		[SerializeField]
		private Transform _container;

		[SerializeField]
		private List<GameObject> _items;

		[Header("Settings")]
		[Tooltip("Sprite khi đã hoàn thành/Active (Màu vàng)")]
		[SerializeField]
		private Sprite _activeSprite;

		[Tooltip("Sprite mặc định chưa hoàn thành")]
		[SerializeField]
		private Sprite _inactiveSprite;

		private List<Image> _spawnedImages;

		private int _currentProgressIndex;

		private int _totalStages;

		public void UpdateInfo(int number)
		{
		}

		public void Increase()
		{
		}
	}
}
