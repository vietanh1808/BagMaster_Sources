using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Constant;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem
{
	public class SkillDataEntityUI : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateHeight_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public SkillDataEntityUI _003C_003E4__this;

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
		private Image rarityImg;

		[SerializeField]
		private TextMeshProUGUI descriptionTxt;

		[SerializeField]
		private GameObject locked;

		[SerializeField]
		private Color lockedColor;

		[SerializeField]
		private Image background;

		[SerializeField]
		private Color[] indexs;

		[SerializeField]
		private EquipmentPassiveUIProfile indexsProfile;

		private float _defaultDescriptionBoxHeight;

		public void UpdateInfo(Rarity rarity, string description, bool unlocked, int rarityLevel = 0)
		{
		}

		public void SetIndex(int index)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateHeight_003Ed__10))]
		public UniTask UpdateHeight()
		{
			return default;
		}
	}
}
