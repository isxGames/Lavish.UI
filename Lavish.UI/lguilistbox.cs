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
	public class lguilistbox : lguielement
	{
		public lguilistbox()
			: base(LavishScript.Objects.GetObject("LavishGUI"))
		{
		}

		public lguilistbox(LavishScriptObject Copy)
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

		public Int32 TextColor
		{
			get
			{
				return GetMember<Int32>("TextColor");
			}
		}

		public Int32 BackgroundColor
		{
			get
			{
				return GetMember<Int32>("BackgroundColor");
			}
		}

		public Int32 Border
		{
			get
			{
				return GetMember<Int32>("Border");
			}
		}

		public Int32 BorderColor
		{
			get
			{
				return GetMember<Int32>("BorderColor");
			}
		}

		public Int32 SelectionColor
		{
			get
			{
				return GetMember<Int32>("SelectionColor");
			}
		}

		public String SortType
		{
			get
			{
				return GetMember<String>("SortType");
			}
		}

		public Boolean SelectMultiple
		{
			get
			{
				return GetMember<Boolean>("SelectMultiple");
			}
		}

		public Boolean AutoSort
		{
			get
			{
				return GetMember<Boolean>("AutoSort");
			}
		}

		public lguilistboxitem Item(Int32 Index)
		{
			return GetMember<lguilistboxitem>("Item", new string[] { Index.ToString() });
		}

		public Int32 Items
		{
			get
			{
				return GetMember<Int32>("Items");
			}
		}

		public lguilistboxitem SelectedItem()
		{
			return GetMember<lguilistboxitem>("SelectedItem");
		}

		public lguilistboxitem SelectedItem(Int32 Index)
		{
			return GetMember<lguilistboxitem>("SelectedItem", new string[] { Index.ToString() });
		}

		public Int32 SelectedItems
		{
			get
			{
				return GetMember<Int32>("SelectedItems");
			}
		}

		public lguilistboxitem OrderedItem(Int32 Index)
		{
			return GetMember<lguilistboxitem>("OrderedItem", new string[] { Index.ToString() });
		}

		public lguilistboxitem ItemByText(String ItemText)
		{
			return GetMember<lguilistboxitem>("ItemByText", new string[] { ItemText });
		}

		public Boolean SetTextColor(String HexColor)
		{
			return ExecuteMethod("SetTextColor", new string[] { HexColor });
		}

		public Boolean SetBackgroundColor(String HexColor)
		{
			return ExecuteMethod("SetBackgroundColor", new string[] { HexColor });
		}

		public Boolean SetBorderColor(String HexColor)
		{
			return ExecuteMethod("SetBorderColor", new string[] { HexColor });
		}

		public Boolean SetSelectionColor(String HexColor)
		{
			return ExecuteMethod("SetSelectionColor", new string[] { HexColor });
		}

		public Boolean SetSortType(String SortType)
		{
			return ExecuteMethod("SetSortType", new string[] { SortType });
		}

		public Boolean SetSelectMultiple(Boolean SelectMultiple)
		{
			return ExecuteMethod("SetSelectMultiple", new string[] { SelectMultiple.ToString() });
		}

		public Boolean SetAutoSort(Boolean AutoSort)
		{
			return ExecuteMethod("SetAutoSort", new string[] { AutoSort.ToString() });
		}

		public Boolean DeselectItem(Int32 ID)
		{
			return ExecuteMethod("DeselectItem", new string[] { ID.ToString() });
		}

		public Boolean SelectItem(Int32 ID)
		{
			return ExecuteMethod("SelectItem", new string[] { ID.ToString() });
		}

		public Boolean ItemToggleSelect(Int32 ID)
		{
			return ExecuteMethod("ItemToggleSelect", new string[] { ID.ToString() });
		}

		public Boolean ClearSelection()
		{
			return ExecuteMethod("ClearSelection");
		}

		public Boolean AddItem(String Item)
		{
			return ExecuteMethod("AddItem", new string[] { Item });
		}

		public Boolean AddItem(String Item, String Value)
		{
			return ExecuteMethod("AddItem", new string[] { Item, Value });
		}
		
		public Boolean AddItem(String Item, String Value, String HexColor)
		{
			return ExecuteMethod("AddItem", new string[] { Item, Value, HexColor });
		}

		public Boolean RemoveItem(Int32 ID)
		{
			return ExecuteMethod("RemoveItem", new string[] { ID.ToString() });
		}

		public Boolean ClearItems()
		{
			return ExecuteMethod("ClearItems");
		}

		public Boolean Sort()
		{
			return ExecuteMethod("Sort");
		}
	}
}

