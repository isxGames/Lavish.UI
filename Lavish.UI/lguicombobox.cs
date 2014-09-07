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
	public class lguicombobox : lguielement
	{
		public lguicombobox()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguicombobox(LavishScriptObject Copy)
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

		public bool Down
		{
			get
			{
				return GetMember<bool>("Down");
			}
		}

		public Int32 Selection
		{
			get
			{
				return GetMember<Int32>("Selection");
			}
		}

		public Boolean SetSelection(String Selection)
		{
			return ExecuteMethod("SetSelection", new string[] { Selection });
		}
	}
}
