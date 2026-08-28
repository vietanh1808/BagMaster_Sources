using UnityEngine;

namespace Game.Combat
{
	public class GameplayScreenPaddingPosition : MonoBehaviour
	{
		public enum Edge
		{
			None = 0,
			Top = 1,
			Bottom = 2,
			Left = 3,
			Right = 4
		}

		public Edge Type;

		public float Padding;

		private void Start()
		{
		}

		private void UpdatePosition()
		{
		}
	}
}
