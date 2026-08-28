using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;

public class BootLoader : MonoBehaviour
{
	[Serializable]
	public class FontEntry
	{
		public TMP_FontAsset Font;

		[Tooltip("Language codes separated by ';' (e.g. 'en;vi'). Leave empty = always load.")]
		public string Languages;
	}

	[CompilerGenerated]
	private sealed class _003CLoadGame_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BootLoader _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadGame_003Ed__5(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CPreloadFonts_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BootLoader _003C_003E4__this;

		private string _003CcurrentLanguage_003E5__2;

		private List<FontEntry>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPreloadFonts_003Ed__7(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWarmUpGlyphs_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BootLoader _003C_003E4__this;

		private GameObject _003CrootGo_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWarmUpGlyphs_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private MMAdditiveSceneLoadingManagerSettings _loadingSceneSettings;

	[SerializeField]
	private TextMeshProUGUI _statusText;

	[SerializeField]
	private List<FontEntry> _fonts;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadGame_003Ed__5))]
	private IEnumerator LoadGame()
	{
		return null;
	}

	private void SetStatusText(string text)
	{
	}

	[IteratorStateMachine(typeof(_003CPreloadFonts_003Ed__7))]
	private IEnumerator PreloadFonts()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWarmUpGlyphs_003Ed__8))]
	private IEnumerator WarmUpGlyphs()
	{
		return null;
	}

	private static bool FontMatchesLanguage(FontEntry entry, string languageCode)
	{
		return false;
	}

	private static string GetWarmUpCharacters(string languageCode)
	{
		return null;
	}
}
