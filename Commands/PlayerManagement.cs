using Sandbox;

namespace Custodia.Commands
{
	public class PlayerManagement
	{
		#nullable enable

		[Command("ban", "player.ban", Description = "Bans a player from the game by name or SteamID.")]
		public virtual void BanPlayer(string id, string durText, string? notes)
		{
			if (float.TryParse(durText, out float duration) && CLib.FindPlayerFromText(id) is Client cl && cl.IsValid())
				Manager.Ban(cl, duration, notes);
		}

		#nullable disable
	}
}
