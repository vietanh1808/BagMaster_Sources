using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game
{
	public class ResourceReturnUI : MonoBehaviour
	{
		private enum ReturnUIType
		{
			Currency = 0,
			Equipment = 1
		}

		[SerializeField]
		private ReturnUIType _type;

		[SerializeField]
		private int _resourceId;

		[SerializeField]
		private bool _autoGetCurrencyId;

		[SerializeField]
		private MMF_Player _hitFeedback;

		[SerializeField]
		private bool _autoAddOnEnable;

		public float ScaleMultiplier;

		public int OverrideLayer;

		private bool _shown;

		private float _hideTime;

		private bool _added;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void Add()
		{
		}

		private void Remove()
		{
		}

		private int GetResourceId()
		{
			return 0;
		}

		public Vector3 GetDestinationPosition()
		{
			return default;
		}

		public void Show(float duration)
		{
		}

		public void Hide()
		{
		}

		public void Hit()
		{
		}

		public void SetCurrencyId(int resourceId)
		{
		}
	}
}
