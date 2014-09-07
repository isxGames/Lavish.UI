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
	public class lguitab : lguielement
	{
		public lguitab()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguitab(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		new public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		new public Int32 ID
		{
			get
			{
				return GetMember<Int32>("ID");
			}
		}

		public Int32 Order
		{
			get
			{
				return GetMember<Int32>("Order");
			}
		}

		public Boolean Select()
		{
			return ExecuteMethod("Select");
		}
		
		public Boolean Remove()
		{
			return ExecuteMethod("Remove");
		}

		public Boolean Move(Int32 Position)
		{
			return ExecuteMethod("Move", new string[] { Position.ToString() });
		}
	}
}
