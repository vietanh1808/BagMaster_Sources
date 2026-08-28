using System.Collections.Generic;
using UnityEngine;

namespace SuperScrollView
{
	public class ChatMsgDataSourceMgr : MonoBehaviour
	{
		private Dictionary<int, PersonInfo> mPersonInfoDict;

		private List<ChatMsg> mChatMsgList;

		private static ChatMsgDataSourceMgr instance;

		private static string[] mChatDemoStrList;

		private static int[] mChatDemoPicList;

		private int mChatCount;

		public static ChatMsgDataSourceMgr Get => null;

		public int TotalItemCount => 0;

		private void Awake()
		{
		}

		public PersonInfo GetPersonInfo(int personId)
		{
			return null;
		}

		public void Init()
		{
		}

		public ChatMsg GetChatMsgByIndex(int index)
		{
			return null;
		}

		private void InitChatDataSource()
		{
		}

		public void AppendOneMsg(int personId)
		{
		}
	}
}
