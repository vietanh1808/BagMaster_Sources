using R3;
using UnityEngine;

namespace Game.Utils.EventBroker
{
	public class EventListener : MonoBehaviour
	{
		protected readonly CompositeDisposable _disposables;

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
