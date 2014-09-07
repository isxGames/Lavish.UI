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
	public class lguicheckbox : lguielement
	{
		public lguicheckbox()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguicheckbox(LavishScriptObject Copy)
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

		public Boolean Checked
		{
			get
			{
				return GetMember<Boolean>("Checked");
			}
		}

		public Boolean SetText(String Value)
		{
			return ExecuteMethod("SetText", new string[] { Value });
		}

		public Boolean SetChecked()
		{
			return ExecuteMethod("SetChecked");
		}

		public Boolean UnsetChecked()
		{
			return ExecuteMethod("UnsetChecked");
		}

		public Boolean ToggleChecked()
		{
			return ExecuteMethod("ToggleChecked");
		}

	}
}
