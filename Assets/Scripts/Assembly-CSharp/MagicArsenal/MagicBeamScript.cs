using UnityEngine;
using UnityEngine.UI;

namespace MagicArsenal
{
	public class MagicBeamScript : MonoBehaviour
	{
		[Header("Prefabs")]
		public GameObject[] beamLineRendererPrefab;

		public GameObject[] beamStartPrefab;

		public GameObject[] beamEndPrefab;

		private BeamType currentBeam;

		private GameObject beamStart;

		private GameObject beamEnd;

		private GameObject beam;

		private LineRenderer line;

		private new Transform transform;

		private float textureScrollOffset;

		[Header("Adjustable Variables")]
		public float beamEndOffset;

		public float textureScrollSpeed;

		public float textureLengthScale;

		[Header("Put Sliders here (Optional)")]
		public Slider endOffSetSlider;

		public Slider scrollSpeedSlider;

		[Header("Put UI Text object here to show beam name")]
		public Text textBeamName;

		private bool isFiringBeam;

		private void Start()
		{
		}

		private void CreateBeamObjects()
		{
		}

		private void Update()
		{
		}

		private void UpdateBeam()
		{
		}

		private void ShootBeamInDir(Vector3 start, Vector3 dir)
		{
		}
	}
}
