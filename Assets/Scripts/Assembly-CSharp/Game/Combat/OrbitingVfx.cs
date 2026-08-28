using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class OrbitingVfx : MonoBehaviour
	{
		[SerializeField]
		private GameObject _defaultVfx;

		[SerializeField]
		private List<SkillVfxData> _skillVfxList;

		[SerializeField]
		private float _vfxDuration;

		[SerializeField]
		private Vector3 _vfxOffset;

		private SkillVfxData _vfxData;

		public void SetVfx(Gear gear)
		{
		}

		private void PlaySkillVFX(SkillCastData data)
		{
		}
	}
}
