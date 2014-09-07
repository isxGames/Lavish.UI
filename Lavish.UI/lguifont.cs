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
	public class lguifont : lguielement
	{
		public lguifont()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguifont(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		new public Int32 Height 
		{
			get
			{
				return GetMember<Int32>("Height");
			}
		}

		new public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		public Int32 Color
		{
			get
			{
				return GetMember<Int32>("Color");
			}
		}

		new public Boolean SetHeight(Int32 Height)
		{
			return ExecuteMethod("SetHeight", new string[] { Height.ToString() });
		}
		
		public Boolean SetName(String Name)
		{
			return ExecuteMethod("SetName", new string[] { Name });
		}

		public Boolean SetColor(String HexColor)
		{
			return ExecuteMethod("SetColor", new string[] { HexColor });
		}

		public Boolean EnableBold()
		{
			return ExecuteMethod("EnableBold");
		}

		public Boolean DisableBold()
		{
			return ExecuteMethod("DisableBold");
		}

		public Boolean ToggleBold()
		{
			return ExecuteMethod("ToggleBold");
		}

	}
}
