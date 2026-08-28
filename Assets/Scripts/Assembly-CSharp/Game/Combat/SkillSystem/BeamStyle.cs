using System.Collections.Generic;
using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class BeamStyle : ProjectileBehaviour, IUpdater
	{
		[SerializeField]
		private GameObject _beamStartPrefab;

		[SerializeField]
		private GameObject _beamEndPrefab;

		[SerializeField]
		private GameObject _beamLinePrefab;

		[SerializeField]
		private float _textureLengthScale;

		[SerializeField]
		private float _textureScrollSpeed;

		private List<LineData> _lineDatas;

		private float _durationCount;

		private bool _ended;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public virtual void CustomUpdate(float dt)
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		protected virtual bool DoBeam()
		{
			return false;
		}

		protected void CreateBeam(Transform start, Transform end, Vector3 startPosition, Vector3 endPosition, bool needStartBeam, bool needEndBeam)
		{
		}

		private void Impact(Unit unit)
		{
		}

		private void Clear()
		{
		}
	}
}
