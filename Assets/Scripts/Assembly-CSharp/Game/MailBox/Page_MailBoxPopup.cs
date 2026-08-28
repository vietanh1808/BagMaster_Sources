using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using EnhancedUI.EnhancedScroller;
using UnityEngine;
using UnityEngine.UI;

namespace Game.MailBox
{
	public class Page_MailBoxPopup : MonoBehaviour, IEnhancedScrollerDelegate
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRefreshList_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Page_MailBoxPopup _003C_003E4__this;

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
		private Button _deleteReadMailButton;

		[SerializeField]
		private Button _claimAllMailButton;

		[SerializeField]
		private EnhancedScroller _scroller;

		[SerializeField]
		private Mail_ListItem _mailItemPrefab;

		[SerializeField]
		private Page_MailBoxPopup_SpecificVIew _specificView;

		private List<Mail_Content_DTO> _mailDisplayData;

		private float _mailItemHeight;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void InitializeDatas()
		{
		}

		private int SortMail(Mail_Content_DTO mail1, Mail_Content_DTO mail2)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CRefreshList_003Ed__13))]
		private UniTask RefreshList()
		{
			return default;
		}

		private void OnDeleteAllReadMail()
		{
		}

		private void OnClaimAllMail()
		{
		}

		private bool HasClaimableMail()
		{
			return false;
		}

		private bool HasDeletableMail()
		{
			return false;
		}

		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}
	}
}
