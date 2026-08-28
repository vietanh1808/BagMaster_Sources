using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class AlimentVisual : MonoBehaviour
	{
		private class Source
		{
			public Elemental Elemental;

			public object Obj;
		}

		[Header("Color")]
		[SerializeField]
		private Color _burnedRendererColor;

		[SerializeField]
		private Color _coldRendererColor;

		[SerializeField]
		private Color _staticRendererColor;

		[SerializeField]
		private Color _poisonRendererColor;

		[Header("VFX")]
		[SerializeField]
		private GameObject _burnedVfx;

		[SerializeField]
		private GameObject _coldVfx;

		[SerializeField]
		private GameObject _staticElectricVfx;

		[SerializeField]
		private GameObject _poisonVfx;

		[SerializeField]
		private Vector3 _vfxOffset;

		private List<Source> _sources;

		private Unit _unit;

		private TargetPoint _positionTransform;

		private GameObject _vfx;

		private GameObject _vfxPrefab;

		private void Start()
		{
		}

		public void Add(Elemental elemental, object source)
		{
		}

		public void Remove(Elemental elemental, object source)
		{
		}

		private void UpdateVisual(Elemental elemental)
		{
		}

		private void SetRendererColor(Color color)
		{
		}

		private void CreateVfx(GameObject prefab)
		{
		}

		private void Cancel()
		{
		}
	}
}
