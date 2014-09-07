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
	public class lguilistboxitem : lguielement
	{
		public lguilistboxitem()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguilistboxitem(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public Int32 TextColor
		{
			get
			{
				return GetMember<Int32>("TextColor");
			}
		}

		new public Int32 ID
		{
			get
			{
				return GetMember<Int32>("ID");
			}
		}

		public Int32 Value
		{
			get
			{
				return GetMember<Int32>("Value");
			}
		}

		public Int32 Order
		{
			get
			{
				return GetMember<Int32>("Order");
			}
		}

		public Int32 Items
		{
			get
			{
				return GetMember<Int32>("Items");
			}
		}

		public string Text
		{
			get
			{
				return GetMember<string>("Text");
			}
		}

		public Boolean SetText(String Text)
		{
			return ExecuteMethod("SetText", new string[] { Text });
		}

		public Boolean SetTextColor(String HexColor)
		{
			return ExecuteMethod("SetTextColor", new string[] { HexColor });
		}
		
		public Boolean SetValue(String Text)
		{
			return ExecuteMethod("SetValue", new string[] { Text });
		}

		public Boolean Select()
		{
			return ExecuteMethod("Select");
		}
		
		public Boolean Deselect()
		{
			return ExecuteMethod("Deselect");
		}
		
		public Boolean Toggle()
		{
			return ExecuteMethod("Toggle");
		}

		public Boolean Remove()
		{
			return ExecuteMethod("Remove");
		}
	}
}
