using Sandbox;

namespace Custodia.Commands
{
	public class PlayerManagement
	{
		#nullable enable

		[Command("ban", Description = "Bans a player from the game by name or SteamID.")]
		public virtual void BanPlayer(string id, string durationText, string? notes)
		{
			if (float.TryParse(durationText, out float duration) && CLib.FindPlayerFromText(id) is Client cl)
				Manager.Ban(cl, duration, notes);
		}

		#nullable disable
	}
}
