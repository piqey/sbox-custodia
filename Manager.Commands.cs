using System.Collections.Generic;
using Sandbox;

namespace Custodia
{
	public static partial class Manager
	{
		public const string MasterConCmdName = "custodia";

		public static IEnumerable<CommandAttribute> Commands => TypeLibrary.GetAttributes<CommandAttribute>();

		[ConCmd.Server(MasterConCmdName)]
		public static void MasterConCmd(string text)
		{
			// insert search and execution of specified command with specified parameters
		}
	}
}
