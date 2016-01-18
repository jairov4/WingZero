using System;

namespace WingZero
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			using (Game game = new Game())
			{				
				game.Run();
			}
		}
	}
}

