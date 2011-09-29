using System.Threading;
using log4net;
using log4net.Config;

namespace log4netTest
{
	internal class Program
	{
		private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));

		private static void Main()
		{
			XmlConfigurator.Configure();

			while( true )
			{
				Logger.Debug("Hello World from log4net");
				Logger.Info("Hello World from log4net");
				Logger.Warn("Hello World from log4net");
				Logger.Error("Hello World from log4net");
				Logger.Fatal("Hello World from log4net");

				Thread.Sleep(10000);
			}
		}
	}
}