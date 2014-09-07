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
	public class lguitext : lguielement
	{
		public lguitext()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguitext(LavishScriptObject Copy)
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
				return GetMember<lguifont>("Text");
			}
		}

		public Boolean SetText(String Value)
		{
			return ExecuteMethod("SetText", new string[] { Value });
		}
	}
}
