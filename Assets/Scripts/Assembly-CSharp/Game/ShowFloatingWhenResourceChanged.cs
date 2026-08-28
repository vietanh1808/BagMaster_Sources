using UnityEngine;

namespace Game
{
	public class ShowFloatingWhenResourceChanged : MonoBehaviour
	{
		[SerializeField]
		private int _resourceId;

		[SerializeField]
		private CurrencyFloating _floatingPrefab;

		[SerializeField]
		private Transform _position;

		[SerializeField]
		private float _floatingScale;

		[SerializeField]
		private bool _showIfPositive;

		[SerializeField]
		private bool _showIfNegative;

		[SerializeField]
		private Vector3 _spawnOffset;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnResourceChanged(OwnedResourceEntity entity, int changedAmount)
		{
		}

		public void Show(int changedAmount)
		{
		}

		public void ShowByResourceId(int resourceId, int changedAmount, float floatingScale)
		{
		}
	}
}
