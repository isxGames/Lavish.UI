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
	public class lguiscrollbar : lguielement
	{
		public lguiscrollbar()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguiscrollbar(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public Boolean Vertical
		{
			get
			{
				return GetMember<Boolean>("Vertical");
			}
		}

		public Int32 Range
		{
			get
			{
				return GetMember<Int32>("Range");
			}
		}

		public Int32 Value
		{
			get
			{
				return GetMember<Int32>("Value");
			}
		}

		public Boolean SetRange(Int32 Range)
		{
			return ExecuteMethod("SetRange", new string[] { Range.ToString() });
		}

		public Boolean RaiseValue(Int32 Value)
		{
			return ExecuteMethod("RaiseValue", new string[] { Value.ToString() });
		}

		public Boolean LowerValue(Int32 Value)
		{
			return ExecuteMethod("LowerValue", new string[] { Value.ToString() });
		}

		public Boolean SetValue(Int32 Value)
		{
			return ExecuteMethod("SetValue", new string[] { Value.ToString() });
		}
	}
}
