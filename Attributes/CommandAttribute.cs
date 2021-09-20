using System;
using Sandbox;

namespace Custodia
{
	[AttributeUsage(AttributeTargets.Method)]
	public class CommandAttribute : LibraryAttribute
	{
		public string CommandText { get; }

		public CommandAttribute(string name) : base(name) =>
			CommandText = name;

		public CommandAttribute(string name, string command) : base(name) =>
			CommandText = command;
	}
}
