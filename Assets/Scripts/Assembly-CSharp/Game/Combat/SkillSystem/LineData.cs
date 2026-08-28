using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class LineData
	{
		public GameObject BeamStart;

		public GameObject BeamEnd;

		public LineRenderer BeamLine;

		public Transform StartAnchor;

		public Transform EndAnchor;

		public float TextureLengthScale;

		public float TextureScrollSpeed;

		public Vector3 StartPosition;

		public Vector3 EndPosition;

		private float _textureScrollOffset;

		public void Clear()
		{
		}

		public void Update()
		{
		}
	}
}
