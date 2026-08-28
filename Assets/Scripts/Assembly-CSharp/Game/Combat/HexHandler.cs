using UnityEngine;

namespace Game.Combat
{
	public abstract class HexHandler : MonoBehaviour
	{
		protected Unit _unit;

		protected bool _inDuration;

		protected StatusData _statusData;

		protected virtual void Awake()
		{
		}

		public virtual StatusData CreateHexStatus(EChangeModelParams param)
		{
			return null;
		}

		protected abstract void CreateHexEffect(EChangeModelParams param);

		protected virtual void Show()
		{
		}

		protected virtual void Hide()
		{
		}

		protected virtual void Destroy()
		{
		}
	}
}
