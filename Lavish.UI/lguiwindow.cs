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
	public class lguiwindow : lguielement
	{
		public lguiwindow()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguiwindow(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public Boolean IsHeightResizable 
		{
			get
			{
				return GetMember<Boolean>("IsHeightResizable");
			}
		}

		public Boolean IsWidthResizable 
		{
			get
			{
				return GetMember<Boolean>("IsWidthResizable");
			}
		}

		public Boolean IsResizable
		{
			get
			{
				return GetMember<Boolean>("IsResizable");
			}
		}

		public Boolean IsMinimizable 
		{
			get
			{
				return GetMember<Boolean>("IsMinimizable");
			}
		}

		public Boolean IsClosable 
		{
			get
			{
				return GetMember<Boolean>("IsClosable");
			}
		}

		public Boolean Minimized 
		{
			get
			{
				return GetMember<Boolean>("Minimized");
			}
		}
		
		public lguielement ClickFocus
		{
			get
			{
				return GetMember<lguielement>("ClickFocus");
			}
		}
	
		public String Title
		{
			get
			{
				return GetMember<String>("Title");
			}
		}

		public Boolean Minimize()
		{
			return ExecuteMethod("Minimize");
		}
	
		public Boolean Unminimize()
		{
			return ExecuteMethod("Unminimize");
		}
	
		public Boolean ToggleMinimize()
		{
			return ExecuteMethod("ToggleMinimize");
		}
	
		public Boolean Reset()
		{
			return ExecuteMethod("Reset");
		}
	
	}
}
