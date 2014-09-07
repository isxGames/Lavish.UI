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
	public class lguitextentry : lguielement
	{
		public lguitextentry()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguitextentry(LavishScriptObject Copy)
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

		public lguifont Font
		{
			get
			{
				return GetMember<lguifont>("Font");
			}
		}

		public Int32 BackgroundColor
		{
			get
			{
				return GetMember<Int32>("BackgroundColor");
			}
		}

		public Int32 BorderColor
		{
			get
			{
				return GetMember<Int32>("BorderColor");
			}
		}

		public Int32 Border
		{
			get
			{
				return GetMember<Int32>("Border");
			}
		}

		public Boolean SetText(String Value)
		{
			return ExecuteMethod("SetText", new string[] { Value });
		}

		public Boolean SetBackgroundColor(String HexColor)
		{
			return ExecuteMethod("SetBackgroundColor", new string[] { HexColor });
		}

		public Boolean SetBorderColor(String HexColor)
		{
			return ExecuteMethod("SetBorderColor", new string[] { HexColor });
		}

	}
}
