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
	public class lguimapblip : lguielement
	{
		public lguimapblip()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguimapblip(LavishScriptObject Copy)
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
		public Point3f Location
		{
			get
			{
				return GetMember<Point3f>("Location");
			}
		}
		public String Custom
		{
			get
			{
				return GetMember<String>("Custom");
			}
		}
		public String Label
		{
			get
			{
				return GetMember<String>("Label");
			}
		}

		public Boolean SetLabel(string Label)
		{
			return ExecuteMethod("SetLabel", new string[] { Label });
		}

		public Boolean SetCustom(string CustomText)
		{
			return ExecuteMethod("SetCustom", new string[] { CustomText });
		}
	}
}
