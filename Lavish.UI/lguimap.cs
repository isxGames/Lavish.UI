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
	public class lguimap : lguielement
	{
		public lguimap()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguimap(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public Point3f Origin
		{
			get
			{
				return GetMember<Point3f>("Origin");
			}
		}

		public float Rotation
		{
			get
			{
				return GetMember<float>("Rotation");
			}
		}

		public String BlipFactory
		{
			get
			{
				return GetMember<String>("BlipFactory");
			}
		}

		public String BlipTemplate
		{
			get
			{
				return GetMember<String>("BlipTemplate");
			}
		}
		
		public float MapSizeX
		{
			get
			{
				return GetMember<float>("MapSizeX");
			}
		}

		public float MapSizeY
		{
			get
			{
				return GetMember<float>("MapSizeY");
			}
		}
		
		public Boolean Radial
		{
			get
			{
				return GetMember<Boolean>("Radial");
			}
		}

		public float ZClipping
		{
			get
			{
				return GetMember<float>("ZClipping");
			}
		}

		public Boolean ShowLabels
		{
			get
			{
				return GetMember<Boolean>("ShowLabels");
			}
			set
			{
				ExecuteMethod("ShowLabels");
			}
		}

		public Int32 Blips
		{
			get
			{
				return GetMember<Int32>("Blips");
			}
		}

		public lguimapblip Blip()
		{
			return GetMember<lguimapblip>("Blip");
		}

		public lguimapblip Blip(String Name)
		{
			return GetMember<lguimapblip>("Blip", new string[] { Name });
		}

		public lguimapblip NextBlip(String Name)
		{
			return GetMember<lguimapblip>("NextBlip", new string[] { Name });
		}

		public Boolean AddBlip(string Name, Int32 x, Int32 y, Int32 z, Int32 Size, String Label, String Template, String ElementType)
		{
			return ExecuteMethod("AddBlip",  new string[] { Name, x.ToString(), y.ToString(), z.ToString(), Size.ToString(), Label, Template, ElementType });
		}

		public Boolean SetOrigin(Int32 x, Int32 y, Int32 z)
		{
			return ExecuteMethod("SetOrigin", new string[] { x.ToString(), y.ToString(), z.ToString() });
		}

		public Boolean SetRotation(Int32 Rotation)
		{
			return ExecuteMethod("SetRotation", new string[] { Rotation.ToString() });
		}

		public Boolean SetMapSize(Int32 x, Int32 y)
		{
			return ExecuteMethod("SetMapSize", new string[] { x.ToString(), y.ToString() });
		}

		public Boolean ClipZ()
		{
			return ExecuteMethod("ClipZ");
		}

		public Boolean UnclipZ()
		{
			return ExecuteMethod("UnclipZ");
		}

		public Boolean ToggleZClipping()
		{
			return ExecuteMethod("ToggleZClipping");
		}

		public Boolean ClipText()
		{
			return ExecuteMethod("ClipText");
		}

		public Boolean UnclipText()
		{
			return ExecuteMethod("UnclipText");
		}

		public Boolean ToggleTextClipping()
		{
			return ExecuteMethod("ToggleTextClipping");
		}

		/*
		 * Defined as set property of ShowLabels member
		public Boolean ShowLabels()
		{			
			return ExecuteMethod("ShowLabels");	
		}
		 */

		public Boolean HideLabels()
		{
			return ExecuteMethod("HideLabels");
		}

		public Boolean ToggleLabels()
		{
			return ExecuteMethod("ToggleLabels");
		}

		public Boolean EnableRotation()
		{
			return ExecuteMethod("EnableRotation");
		}

		public Boolean DisableRotation()
		{
			return ExecuteMethod("DisableRotation");
		}

		public Boolean ToggleRotation()
		{
			return ExecuteMethod("ToggleRotation");
		}
	}


}
