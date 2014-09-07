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
	public class lguiconsole : lguielement
	{
		public lguiconsole()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguiconsole(LavishScriptObject Copy)
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

		public Int32 BorderColor 
		{
			get
			{
				return GetMember<Int32>("BorderColor");
			}
		}

		public Int32 ScrollbackColor 
		{
			get
			{
				return GetMember<Int32>("ScrollbackColor");
			}
		}

		public Int32 BackgroundColor 
		{
			get
			{
				return GetMember<Int32>("BackgroundColor");
			}
		}

		public Int32 SelectionColor
		{
			get
			{
				return GetMember<Int32>("SelectionColor");
			}
		}

		public bool SetBorderColor(String HexColor)
		{
			return ExecuteMethod("SetBorderColor", new string[] { HexColor });
		}

		public bool SetScrollbackColor(String HexColor)
		{
			return ExecuteMethod("SetScrollbackColor", new string[] { HexColor });
		}

		public bool SetBackgroundColor(String HexColor)
		{
			return ExecuteMethod("SetBackgroundColor", new string[] { HexColor });
		}

		public bool SetSelectionColor(String HexColor)
		{
			return ExecuteMethod("SetSelectionColor", new string[] { HexColor });
		}

		public bool Echo(String strOut)
		{
			return ExecuteMethod("Echo", new string[] { strOut });
		}

	}
}
