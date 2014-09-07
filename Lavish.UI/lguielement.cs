using System;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Lavish.UI
{
	public class lguielement : LavishScriptObject
	{
		public lguielement()
			: base(LavishScript.Objects.GetObject("lguielement"))
		{
		}

		public lguielement(LavishScriptObject Copy)
			: base(Copy)
		{
		}

		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		public Int32 ID
		{
			get
			{
				return GetMember<Int32>("ID");
			}
		}

		public Int32 X
		{
			get
			{
				return GetMember<Int32>("X");
			}
		}

		public Int32 Y
		{
			get
			{
				return GetMember<Int32>("Y");
			}
		}

		public Int32 AbsoluteX
		{
			get
			{
				return GetMember<Int32>("AbsoluteX");
			}
		}

		public Int32 AbsoluteY
		{
			get
			{
				return GetMember<Int32>("AbsoluteY");
			}
		}

		public Int32 Width
		{
			get
			{
				return GetMember<Int32>("Width");
			}
		}

		public Int32 Height
		{
			get
			{
				return GetMember<Int32>("Height");
			}
		}

		public Boolean Visible
		{
			get
			{
				return GetMember<Boolean>("Visible");
			}
		}

		public Boolean AlwaysOnTop
		{
			get
			{
				return GetMember<Boolean>("AlwaysOnTop");
			}
		}

		public Boolean MouseOver
		{
			get
			{
				return GetMember<Boolean>("MouseOver");
			}
		}

		public Boolean Focus
		{
			get
			{
				return GetMember<Boolean>("Focus");
			}
		}

		public String Type
		{
			get
			{
				return GetMember<String>("Type");
			}
		}

		public lguielement Parent
		{
			get
			{
				return GetMember<lguielement>("Parent");
			}
		}

		public lguielement Children
		{
			get
			{
				return GetMember<lguielement>("Children");
			}
		}

		public lguielement Next
		{
			get
			{
				return GetMember<lguielement>("Next");
			}
		}

		public lguielement Previous
		{
			get
			{
				return GetMember<lguielement>("Previous");
			}
		}

		public lguielement FindChild(String ElementName)
		{
			return new lguielement(GetMember("FindChild", new string[] { ElementName }));
		}

		public lguielement FindUsableChild(String ElementName, String ElementType)
		{
			return new lguielement(GetMember("FindUsableChild", new string[] { ElementName, ElementType }));		
		}

		public Boolean LeftClickThru
		{
			get
			{
				return GetMember<Boolean>("LeftClickThru");
			}
		}

		public Boolean RightClickThru
		{
			get
			{
				return GetMember<Boolean>("RightClickThru");
			}
		}

		public float Alpha
		{
			get
			{
				return GetMember<float>("Alpha");
			}
		}

		public float AbsoluteAlpha
		{
			get
			{
				return GetMember<float>("AbsoluteAlpha");
			}
		}

		public float FadeAlpha
		{
			get
			{
				return GetMember<float>("FadeAlpha");
			}
		}

		public UInt32 FadeDelay
		{
			get
			{
				return GetMember<UInt32>("FadeDelay");
			}
		}

		public UInt32 FadeDuration
		{
			get
			{
				return GetMember<UInt32>("FadeDuration");
			}
		}

		public String FadeState
		{
			get
			{
				return GetMember<String>("FadeState");
			}
		}

		public bool AddChild(string ChildType, string ChildName, string ChildXML)
		{
			return ExecuteMethod("AddChild", new string[] { ChildType, ChildName, ChildXML }); ;
		}

		public Boolean SetX(Int32 x)
		{
			return ExecuteMethod("SetX", new string[] { x.ToString() });
		}

		public Boolean SetY(Int32 y)
		{
			return ExecuteMethod("SetY", new string[] { y.ToString() });
		}

		public Boolean SetWidth(Int32 Width)
		{
			return ExecuteMethod("SetWidth", new string[] { Width.ToString() });
		}

		public Boolean SetHeight(Int32 Height)
		{
			return ExecuteMethod("SetHeight", new string[] { Height.ToString() });
		}

		public Boolean SetAlpha(Int32 Alpha)
		{
			return ExecuteMethod("SetAlpha", new string[] { Alpha.ToString() });
		}

		public Boolean SetFadeAlpha(Int32 FadeAlpha)
		{
			return ExecuteMethod("SetFadeAlpha", new string[] { FadeAlpha.ToString() });
		}

		public Boolean SetFadeDelay(Int32 FadeDelay)
		{
			return ExecuteMethod("SetFadeDelay", new string[] { FadeDelay.ToString() });
		}

		public Boolean SetFadeDuration(Int32 FadeDuration)
		{
			return ExecuteMethod("SetFadeDuration", new string[] { FadeDuration.ToString() });
		}

		public bool LeftClick()
		{
			return ExecuteMethod("LeftClick");
		}

		public bool LeftMouseDown()
		{
			return ExecuteMethod("LeftMouseDown");
		}

		public bool LeftMouseUp()
		{
			return ExecuteMethod("LeftMouseUp");
		}

		public bool RightClick()
		{
			return ExecuteMethod("RightClick");
		}

		public bool RightMouseDown()
		{
			return ExecuteMethod("RightMouseDown");
		}

		public bool RightMouseUp()
		{
			return ExecuteMethod("RightMouseUp");
		}

		public bool SetFocus()
		{
			return ExecuteMethod("SetFocus");
		}

		public bool SetZOrder(String ZOrder)
		{
			return ExecuteMethod("SetZOrder", new string[] { ZOrder });
		}

		public bool Show()
		{
			return ExecuteMethod("Show");
		}

		public bool Hide()
		{
			return ExecuteMethod("Hide");
		}

		public bool ToggleVisible()
		{
			return ExecuteMethod("ToggleVisible");
		}

		public bool Destroy()
		{
			return ExecuteMethod("Destroy");
		}

		public bool SetLeftClickThru(Boolean ClickThru)
		{
			return ExecuteMethod("SetLeftClickThru", new string[] { ClickThru.ToString() });
		}

		public bool SetRightClickThru(Boolean ClickThru)
		{
			return ExecuteMethod("SetRightClickThru", new string[] { ClickThru.ToString() });
		}

		public bool BeginFade()
		{
			return ExecuteMethod("BeginFade");
		}

		public bool ResetFade()
		{
			return ExecuteMethod("ResetFade");
		}

		public bool InstantFade()
		{
			return ExecuteMethod("InstantFade");
		}

	}
}
