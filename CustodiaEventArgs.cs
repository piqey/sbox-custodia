using System;
using Sandbox;

namespace Custodia
{
	public partial class Game
	{
		public class CustodiaEventArgs : EventArgs
		{
			public Client Client { get; init; }
			public bool Restrict { get; set; } = false;
		}
	}
}
