using System.Linq;
using Sandbox;

namespace Custodia
{
	public static partial class Manager
	{
		private static void CanPlayerJoin(Game.CustodiaEventData eData)
		{
			bool clientMatch = Bans.Where(b => eData.Client.SteamId == b.SteamId)
				.Any();
			
			if (clientMatch)
				eData.Restrict = true;
		}
		
		private static void CanPlayerSpeak(Game.CustodiaEventData eData)
		{

		}
	}
}
