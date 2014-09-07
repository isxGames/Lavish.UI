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
	public class lguigauge : lguielement
	{
		public lguigauge()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguigauge(LavishScriptObject Copy)
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

		public float Range
		{
			get
			{
				return GetMember<float>("Range");
			}
		}

		public float Value
		{
			get
			{
				return GetMember<float>("Value");
			}
		}

		public Boolean SetRange(float Range)
		{
			return ExecuteMethod("SetRange", new string[] { Range.ToString() });
		}

		public Boolean SetValue(float Value)
		{
			return ExecuteMethod("SetValue", new string[] { Value.ToString() });
		}
	}
}
