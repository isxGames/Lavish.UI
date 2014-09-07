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
	public class TLO
	{
		// http://www.lavishsoft.com/wiki/index.php/LavishGUI:UIElement_%28Top-Level_Object%29
		public lguielement UIElement(string FQN)
		{
			LavishScriptObject Obj = LavishScript.Objects.GetObject("UIElement", new string[] { FQN });
			return new lguielement(Obj);
		}

		// http://www.lavishsoft.com/wiki/index.php/LavishGUI:UIElement_%28Top-Level_Object%29
		public lguielement UIElement(Int32 ElementID)
		{
			LavishScriptObject Obj = LavishScript.Objects.GetObject("UIElement", new string[] { ElementID.ToString() });
			return new lguielement(Obj);
		}

		// http://www.lavishsoft.com/wiki/index.php/LavishGUI:LavishGUI_%28Top-Level_Object%29
		public lavishgui LavishGUI()
		{
			LavishScriptObject Obj = LavishScript.Objects.GetObject("LavishGUI");
			return new lavishgui(Obj);
		}

		// http://www.lavishsoft.com/wiki/index.php/LavishGUI:UserInput_%28Top-Level_Object%29
		public string UserInput()
		{
			LavishScriptObject Obj = LavishScript.Objects.GetObject("UserInput");
			return Obj.ToString();
		}
	}
}
