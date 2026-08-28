using System.Collections.Generic;
using UnityEngine;

namespace Game.GUI
{
	[DefaultExecutionOrder(10)]
	public class VisibleUiWatcher : UiBehaviour
	{
		private const string OptionGroupName = "Children visibility check options";

		public bool CheckOnAwaken;

		public bool CheckOnEnabled;

		public bool CheckOnHierarchyChanged;

		public bool OnlyCheckWhileVisible;

		public bool OnlyCheckDirectChildren;

		public bool CheckSelf;

		public Paddings VisiblePaddings;

		[SerializeField]
		private RectTransform _contentMask;

		private readonly Dictionary<Transform, IVisibleUi> _children;

		private bool ShouldCheckVisibility => false;

		protected override void OnValidate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		public override void OnUiBecameVisible()
		{
		}

		private void OnDisable()
		{
		}

		public void CheckChildrenVisibility()
		{
		}

		private void OnTransformChildrenChanged()
		{
		}

		private void AddChildTransforms(bool canCheckVisibility)
		{
		}

		private void TryAddChild(Transform childTransform, bool canCheckVisibility)
		{
		}

		private void UpdateChildVisibleState(IVisibleUi child)
		{
		}
	}
}
