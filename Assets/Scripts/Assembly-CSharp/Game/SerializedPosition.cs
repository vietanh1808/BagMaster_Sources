using System;
using UnityEngine;

namespace Game
{
	[Serializable]
	public struct SerializedPosition
	{
		[SerializeField]
		[Tooltip("Target transform to get position from")]
		private Transform _target;

		[SerializeField]
		[Tooltip("Offset from target transform")]
		private Vector3 _offset;

		[Tooltip("Fallback value when target transform is not assigned")]
		[SerializeField]
		private Vector3 _position;

		public Vector3 Position => default;
	}
}
