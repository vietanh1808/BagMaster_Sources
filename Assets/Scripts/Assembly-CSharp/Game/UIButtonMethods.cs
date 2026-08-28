using UnityEngine;

namespace Game
{
	public class UIButtonMethods : MonoBehaviour
	{
		[SerializeReference]
		public GameObject Path;

		public int Layer;

		[Header("Sound")]
		[SerializeField]
		private string _popSound;

		private UINagivator Nagivator => null;

		public virtual void Push()
		{
		}

		public virtual void SwitchToFeature(string name)
		{
		}

		public virtual void PushModal()
		{
		}

		public virtual void Pop()
		{
		}

		public virtual void PopContaining()
		{
		}

		public virtual void PopAll()
		{
		}

		public virtual void PopBuiltInMethod()
		{
		}

		public virtual void PopModal()
		{
		}

		public void DestroyGameObject(GameObject target)
		{
		}

		public void UseNavigatorButton()
		{
		}

		public void Vibrate()
		{
		}
	}
}
