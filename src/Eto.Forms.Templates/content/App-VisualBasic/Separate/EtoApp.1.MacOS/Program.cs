﻿namespace EtoApp._1.Mac
{
	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			new Application(Eto.Platforms.macOS).Run(new MainForm());
		}
	}
}
