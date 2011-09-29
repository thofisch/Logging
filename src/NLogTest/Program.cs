using System.Threading;
using NLog;

namespace NLogTest
{
	internal class Program
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		private static void Main()
		{
			while( true )
			{
				Logger.Debug("Hello World from NLog");
				Logger.Info("Hello World from NLog");
				Logger.Warn("Hello World from NLog");
				Logger.Error("Hello World from NLog");
				Logger.Fatal("Hello World from NLog");

				Thread.Sleep(10000);
			}
		}
	}
}