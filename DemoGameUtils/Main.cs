using System;
using GameUtils;

namespace DemoGameUtils
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dice d = new Dice ();
			Console.WriteLine (d.Roll (3));
		}
	}
}
