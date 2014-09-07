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
	public class lguihudelement : lguielement
	{
		public lguihudelement()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguihudelement(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public string Text
		{
			get
			{
				return GetMember<string>("Text");
			}
		}

		public string Group
		{
			get
			{
				return GetMember<string>("Group");
			}
		}

		public lguifont Font
		{
			get
			{
				return GetMember<lguifont>("Font");
			}
		}

		public Int32 UpdateInterval 
		{
			get
			{
				return GetMember<Int32>("UpdateInterval");
			}
		}
		
		public Boolean SetText(String Text)
		{
			return ExecuteMethod("SetText", new string[] { Text });
		}

		public Boolean SetGroup(String Group)
		{
			return ExecuteMethod("SetGroup", new string[] { Group });
		}

		public Boolean SetUpdateInterval(Int32 Interval)
		{
			return ExecuteMethod("SetUpdateInterval", new string[] { Interval.ToString() });
		}

	}
}
