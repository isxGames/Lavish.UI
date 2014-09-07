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
	public class lavishgui : LavishScriptObject
	{
		public lavishgui()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lavishgui(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public string Version
		{
			get
			{
				return GetMember<string>("Version");
			}
		}

		public string APIVersion
		{
			get
			{
				return GetMember<string>("APIVersion");
			}
		}
	}
}
