using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class BagLayoutManager : MonoBehaviour
	{
		[SerializeField]
		private LayoutType[] _layoutPool;

		[SerializeField]
		protected Transform _layoutContainer;

		[SerializeField]
		protected Transform _layoutReference;

		[SerializeField]
		protected Vector3 _positionOffset;

		[Header("Events")]
		public UnityEvent<GameObject> OnLayoutCreatedEvent;

		protected GameObject _currentLayout;

		public string LayoutName => null;

		public GameObject CurrentLayout => null;

		public Vector2Int ConvertToGridPosition(Vector2 worldPosition)
		{
			return default;
		}

		public GameObject CreateLayout(string layoutName)
		{
			return null;
		}

		protected GameObject SpawnLayout(LayoutType layoutPrefab)
		{
			return null;
		}

		private LayoutType GetLayoutPrefab(string layoutName)
		{
			return null;
		}

		private LayoutType GetRandomLayout()
		{
			return null;
		}

		private void FixLayoutRotation(GameObject layout)
		{
		}
	}
}
