using System;
namespace Dash.Helpers
{
	public static class ConsoleLogger
	{

		public static void LogDebug(string text, params object[] args)
		{
			#if DEBUG
				if (args == null)
					Console.WriteLine (String.Format ("DEBUG: " + text));
				else
					Console.WriteLine (String.Format ("DEBUG: " + text, args));
			#endif
		}
	}
}

