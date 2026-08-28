using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using SFB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Testing
{
	public class ToolMenu : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ToolMenu _003C_003E4__this;

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

		[Header("UI")]
		[SerializeField]
		private TextMeshProUGUI _scenarioText;

		[SerializeField]
		private Button _scenarioButton;

		[SerializeField]
		private Button _battleButton;

		[Header("Test")]
		[SerializeField]
		private Button _defaultTestAllCampaignButton;

		[SerializeField]
		private Button _defaultTestAllGoldCaveButton;

		[SerializeField]
		private Button _defaultTestAllSkyTowerButton;

		[SerializeField]
		private Button _defaultTestAllElemetal1Button;

		[SerializeField]
		private Button _defaultTestAllElemetal2Button;

		[SerializeField]
		private Button _defaultTestAllElemetal3Button;

		[SerializeField]
		private Button _defaultTestAllElemetal4Button;

		private IStandaloneFileBrowser _standaloneFileBrowser;

		private List<ScenarioData> _scenarioDatas;

		private string FolderHistory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__15))]
		private void Start()
		{
		}

		private void ChooseScenario()
		{
		}

		private int GetInt(string[] fields, int index)
		{
			return 0;
		}

		private float GetFloat(string[] fields, int index)
		{
			return 0f;
		}

		private void OverrideScenarioWithDungeon(int dungeonId)
		{
		}

		private void OverrideScenarioWithCampaignCustomTestProfile(int campaignCount)
		{
		}

		private void OverrideScenarioWithDungeonCustomTestProfile(int dungeonId, int floorCount)
		{
		}

		private void Battle()
		{
		}

		private List<TestProfileData.Sub> GetListCombatDataOfCampaign()
		{
			return null;
		}

		private List<TestProfileData.Sub> GetListCombatDataOfDungeonId(int id)
		{
			return null;
		}
	}
}
