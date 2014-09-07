/*
 * LavishUITest: A test utility for Lavish.UI.dll
 * Copyright (c) 2007 isxGames & CyberTech (cybertech@gmail.com)
 *
 * Repository located at https://github.com/isxGames/Lavish.UI
 */

using System;
using System.Windows.Forms;
using LavishVMAPI;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace LavishUITest
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			InnerSpace.Echo(" ");
			InnerSpace.Echo("LavishUITest: Starting");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			LavishVMAPI.Frame.Lock();
			Lavish.UI.TLO UI_TLO = new Lavish.UI.TLO();
			using (new FrameLock(true))
			{
				Lavish.UI.lavishgui LGUI = UI_TLO.LavishGUI();
				InnerSpace.Echo("LGUI.APIVersion: " + LGUI.APIVersion);
				InnerSpace.Echo("LGUI.Version: " + LGUI.Version);
			}

			Lavish.UI.lguielement Patcher = UI_TLO.UIElement("patcher");
			using (new FrameLock(true))
			{
				InnerSpace.Echo("Patcher Object Invalid: " + LavishScriptObject.IsNullOrInvalid(Patcher).ToString());
				InnerSpace.Echo("Patch Object Name: " + Patcher.Name);
				InnerSpace.Echo("Calling Patcher.Show() + Sleep");
				Patcher.Show();
			}
			
			System.Threading.Thread.Sleep(1000);
			
			using (new FrameLock(true))
			{
				InnerSpace.Echo("Calling Patcher.Hide()");
				Patcher.Hide();
			}
			// Above are just some basic tests

			// TODO -- finish Form1, add ability to create a window, populate it with some tabs, controls, etc.
			//Application.Run(new Form1());
			InnerSpace.Echo("LavishUITest: Exiting");
		}
	}
}
