﻿#region

using System;
using System.Windows.Forms;

#endregion

namespace Themer.Sample
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Showcase());
		}
	}
}