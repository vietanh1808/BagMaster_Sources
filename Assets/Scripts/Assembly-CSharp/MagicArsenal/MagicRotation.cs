using UnityEngine;

namespace MagicArsenal
{
	public class MagicRotation : MonoBehaviour
	{
		public enum spaceEnum
		{
			Local = 0,
			World = 1
		}

		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		public spaceEnum rotateSpace;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
