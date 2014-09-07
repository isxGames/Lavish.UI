/*
 * Lavish.UI: A .NET wrapper for LavishSofts LavishGUI objects
 * Copyright (c) 2007 isxGames & CyberTech (cybertech@gmail.com)
 *
 * Repository located at https://github.com/isxGames/Lavish.UI
 */

using System;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Lavish.UI
{
	public class lguitabcontrol : lguielement
	{
		public lguitabcontrol()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguitabcontrol(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public lguifont Font
		{
			get
			{
				return GetMember<lguifont>("Font");
			}
		}

		public Int32 Tabs
		{
			get
			{
				return GetMember<Int32>("Tabs");
			}
		}
		
		public lguitab SelectedTab
		{
			get
			{
				return GetMember<lguitab>("SelectedTab");
			}
		}

		public lguitab Tab(Int32 TabID)
		{
			return GetMember<lguitab>("SelectedTab", new string[] { TabID.ToString() });
		}

		public lguitab Tab(String TabName)
		{
			return GetMember<lguitab>("SelectedTab", new string[] { TabName });
		}

		public Boolean AddTab(String TabName)
		{
			return ExecuteMethod("AddTab", new string[] { TabName });
		}
	}
}
