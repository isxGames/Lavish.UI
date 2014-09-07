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
	public class lguitexture : lguielement
	{
		public lguitexture()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguitexture(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		/*
		public filepath Filename
		{
			get
			{
				return GetMember<filepath>("Filename");
			}
		}
		 */
		public Int32 ColorKey
		{
			get
			{
				return GetMember<Int32>("ColorKey");
			}
		}
	
		new public float Alpha
		{
			get
			{
				return GetMember<float>("Alpha");
			}
		}

		public Int32 ColorMask
		{
			get
			{
				return GetMember<Int32>("ColorMask");
			}
		}

		public Int32 Border
		{
			get
			{
				return GetMember<Int32>("Border");
			}
		}

		public Int32 Orientation
		{
			get
			{
				return GetMember<Int32>("Orientation");
			}
		}

		public Int32 Left
		{
			get
			{
				return GetMember<Int32>("Left");
			}
		}

		public Int32 Right
		{
			get
			{
				return GetMember<Int32>("Right");
			}
		}

		public Int32 Top
		{
			get
			{
				return GetMember<Int32>("Top");
			}
		}

		public Int32 Bottom
		{
			get
			{
				return GetMember<Int32>("Bottom");
			}
		}

		public Boolean HasRect
		{
			get
			{
				return GetMember<Boolean>("HasRect");
			}
		}

		public Boolean HasAlpha
		{
			get
			{
				return GetMember<Boolean>("HasAlpha");
			}
		}

		public Boolean HasColorMask
		{
			get
			{
				return GetMember<Boolean>("HasColorMask");
			}
		}

		public Boolean Bold
		{
			get
			{
				return GetMember<Boolean>("Bold");
			}
		}

		public Boolean SetRect(Int32 Left, Int32 Right, Int32 Top, Int32 Bottom)
		{
			return ExecuteMethod("SetRect", new string[] { Left.ToString(), Right.ToString(), Top.ToString(), Bottom.ToString() });
		}
		
		public Boolean SetAlpha(float Alpha)
		{
			return ExecuteMethod("SetAlpha", new string[] { Alpha.ToString() });
		}

		public Boolean SetColorMask(String HexColorMask)
		{
			return ExecuteMethod("SetColorMask", new string[] { HexColorMask });
		}

		public Boolean SetOrientation(Int32 Orientation)
		{
			return ExecuteMethod("SetOrientation", new string[] { Orientation.ToString() });
		}

		public Boolean SetBorder(Int32 Border)
		{
			return ExecuteMethod("SetBorder", new string[] { Border.ToString() });
		}

		public Boolean UnsetRect()
		{
			return ExecuteMethod("UnsetRect");
		}

		public Boolean UnsetColorMask()
		{
			return ExecuteMethod("UnsetColorMask");
		}

		public Boolean UnsetAlpha()
		{
			return ExecuteMethod("UnsetAlpha");
		}
	}
}
