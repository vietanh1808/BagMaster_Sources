using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveConflictPopup : MonoBehaviour
{
	public enum SaveChoice
	{
		Cloud = 0,
		Local = 1
	}

	public readonly struct SaveSummary
	{
		public readonly int Campaign;

		public readonly int Gems;

		public readonly int Gold;

		public SaveSummary(int campaign, int gems, int gold)
		{
			Campaign = 0;
			Gems = 0;
			Gold = 0;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<SaveChoice> _003C_003Et__builder;

		public SaveSummary cloud;

		public SaveSummary local;

		private UniTask<SaveChoice>.Awaiter _003C_003Eu__1;

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
	private struct _003CShowInternalAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<SaveChoice> _003C_003Et__builder;

		public SaveConflictPopup _003C_003E4__this;

		public SaveSummary cloud;

		public SaveSummary local;

		private UniTask<SaveChoice>.Awaiter _003C_003Eu__1;

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

	private static SaveConflictPopup _instance;

	[Header("Cloud save (social account)")]
	[SerializeField]
	private TextMeshProUGUI _cloudCampaignText;

	[SerializeField]
	private TextMeshProUGUI _cloudGemsText;

	[SerializeField]
	private TextMeshProUGUI _cloudGoldText;

	[Header("Local save (device account)")]
	[SerializeField]
	private TextMeshProUGUI _localCampaignText;

	[SerializeField]
	private TextMeshProUGUI _localGemsText;

	[SerializeField]
	private TextMeshProUGUI _localGoldText;

	[Header("Buttons")]
	[SerializeField]
	private GameObject _popup;

	[SerializeField]
	private Button _cloudButton;

	[SerializeField]
	private Button _localButton;

	private UniTaskCompletionSource<SaveChoice> _tcs;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__16))]
	public static UniTask<SaveChoice> ShowAsync(SaveSummary cloud, SaveSummary local)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CShowInternalAsync_003Ed__17))]
	private UniTask<SaveChoice> ShowInternalAsync(SaveSummary cloud, SaveSummary local)
	{
		return default;
	}

	private static void Fill(SaveSummary summary, TextMeshProUGUI campaignText, TextMeshProUGUI gemsText, TextMeshProUGUI goldText)
	{
	}

	private void Resolve(SaveChoice choice)
	{
	}
}
