using System.Collections.Generic;
using Game.CodedAnimation;
using MoreMountains.Tools;
using UnityEngine;

namespace Game.Combat
{
	public class GearOrganizer : MonoBehaviour, MMEventListener<FloatGearAppearEvent>, MMEventListenerBase, MMEventListener<FloatGearVisibleEvent>
	{
		public class OrbiterData
		{
			public Gear Gear;

			public OrbitingGear Orbiter;

			public bool Remain;
		}

		[SerializeField]
		private Unit _owner;

		[SerializeField]
		private OrbitingGear _itemPrefab;

		[SerializeField]
		private float _radius;

		[SerializeField]
		private float _arcDistance;

		[SerializeField]
		private float _gearAngle;

		[SerializeField]
		private float[] _arcs;

		[SerializeField]
		private float[] _maxSpacings;

		[SerializeField]
		private int[] _maxGearPerArcs;

		[SerializeField]
		private float[] _defaultAngles;

		[SerializeField]
		private float[] _yDistances;

		[SerializeField]
		private float _pivotAngle;

		[SerializeField]
		private FloatGearReturnAnimation _floatGearReturnAnimation;

		[SerializeField]
		[Range(1f, 49f)]
		private int _debugNumber;

		private List<OrbiterData> _orbiterDatas;

		public IReadOnlyList<OrbiterData> OrbiterDatas => null;

		public bool Ready { get; private set; }

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnMMEvent(FloatGearAppearEvent eventData)
		{
		}

		public void OnMMEvent(FloatGearVisibleEvent eventData)
		{
		}

		private void CreateOrbiters()
		{
		}

		private OrbitingGear CreateOrbiter(Gear gear)
		{
			return null;
		}

		private void RemoveUnusedOrbiters()
		{
		}

		private void OrganizeOrbiters()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
