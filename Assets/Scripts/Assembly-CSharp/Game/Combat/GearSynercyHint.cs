using System.Collections.Generic;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class GearSynercyHint : MonoBehaviour
	{
		[SerializeField]
		private Gear _gear;

		[SerializeField]
		private Color _canBuffOtherColor;

		[SerializeField]
		private Color _canBuffSelfColor;

		[SerializeField]
		private Color _inSynercyColor;

		[SerializeField]
		private GameObject _inSynercyMark;

		[SerializeField]
		private List<GameObject> _synercyMarkRenderers;

		[SerializeField]
		private Vector3 _synercyMarkRenderersOffset;

		[SerializeField]
		private MMF_Player _inSynercyMarkFeedback;

		[SerializeField]
		private Vector3 _synercyMarkOffset;

		private Color _initialColor;

		private GearSynercyStars _synercyStars;

		public Gear Gear => null;

		public GearSynercyStars SynercyStars => null;

		private void Start()
		{
		}

		private void UpdateMarkPosition()
		{
		}

		private void SetColor(Color color)
		{
		}

		public void SetInitialColor()
		{
		}

		public void SetInSynercyColor()
		{
		}

		public void SetCanBuffOtherColor()
		{
		}

		public void SetCanBuffSelfColor()
		{
		}

		public void SetMarkActive(bool active, int number)
		{
		}

		public void RevertColor()
		{
		}

		public void CreateSynercyMarkRenderers(int number)
		{
		}
	}
}
