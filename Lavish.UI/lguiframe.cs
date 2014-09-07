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
	public class lguiframe : lguielement
	{
		public lguiframe()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguiframe(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public Int32 BackGroundColor
		{
			get
			{
				return GetMember<Int32>("BackGroundColor");
			}
		}


		public Int32 BorderColor 
		{
			get 
			{
				return GetMember<Int32>("BorderColor");
			}
		}

		public lguitexture Texture
		{
			get
			{
				return GetMember<lguitexture>("Texture");
			}
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
