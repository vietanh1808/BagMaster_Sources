using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat.SkillSystem;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Game.EquipmentSystem
{
	public class EquipmentDetailsInfo : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadVideoPreview_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public EquipmentDetailsInfo _003C_003E4__this;

			public string assetName;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSnapScrollToTopAfterLayout_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public EquipmentDetailsInfo _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private Image _equipmentSkillIcon;

		[SerializeField]
		private TextMeshProUGUI _equipmentSkillName;

		[SerializeField]
		private TextMeshProUGUI _equipmentSkillDescription;

		[SerializeField]
		private VideoPlayer _equipmentVideoPreview;

		[SerializeField]
		private ScrollRect _detailsScrollRect;

		private EquipmentData _equipmentData;

		private AsyncOperationHandle _loadPreviewHandle;

		public void UpdateInfo(EquipmentData data)
		{
		}

		[AsyncStateMachine(typeof(_003CSnapScrollToTopAfterLayout_003Ed__8))]
		private UniTaskVoid SnapScrollToTopAfterLayout()
		{
			return default;
		}

		private void SnapScrollToTop()
		{
		}

		private void UpdateSkillUI()
		{
		}

		private SkillData GetSignatureSkill()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadVideoPreview_003Ed__12))]
		private UniTask LoadVideoPreview(string assetName)
		{
			return default;
		}

		private void ReleasePreview()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
