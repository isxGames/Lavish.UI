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
	public class lguibutton : lguielement
	{
		public lguibutton()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguibutton(LavishScriptObject Copy)
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

		public Boolean Down
		{
			get
			{
				return GetMember<Boolean>("Down");
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
		
		public Boolean SetText(String Value)
		{
			return ExecuteMethod("SetText", new string[] { Value });
		}

		public Boolean SetBackGroundColor(String Value)
		{
			return ExecuteMethod("SetBackGroundColor", new string[] { Value });
		}

	}
}