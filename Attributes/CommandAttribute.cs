using System;
using Sandbox;

namespace Custodia
{
	[AttributeUsage(AttributeTargets.Method)]
	public class CommandAttribute : LibraryAttribute
	{
		public string CommandText { get; }
		public string Permission { get; }

		public CommandAttribute(string name, string permission = "") : base(name)
		{
			CommandText = name;
			Permission = permission;
		}

		public CommandAttribute(string name, string command, string permission = "") : base(name)
		{
			CommandText = command;
			Permission = permission;
		}
	}
}
