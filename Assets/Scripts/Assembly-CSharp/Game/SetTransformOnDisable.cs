using UnityEngine;

namespace Game
{
	public class SetTransformOnDisable : MonoBehaviour
	{
		public bool SetLocalScale;

		public Vector3 LocalScale;

		public bool SetLocalPosition;

		public Vector3 LocalPosition;

		public bool SetLocalRotation;

		public Vector3 LocalRotation;

		private void OnDisable()
		{
		}
	}
}
