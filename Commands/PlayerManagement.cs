using Sandbox;

namespace Custodia.Commands
{
	public static class PlayerManagement
	{
		[Command("ban", "player.ban", Description = "Bans a player from the game by name or SteamID.")]
		public static void BanPlayer(string id, string durText, string notes)
		{
			if (long.TryParse(durText, out long duration) && CLib.TryFindPlayerFromText(id, out Client cl) && cl.IsValid())
				Manager.Ban(cl, duration, notes);
			else if (long.TryParse(id, out long plyId))
				Manager.Ban(plyId, duration, notes);
		}

		[Command("unban", "player.ban", Description = "Unbans a previously banned player by SteamID.")]
		public static void UnbanPlayer(long id)
		{
			Manager.Unban(id);
		}

		[Command("mute", "player.mute", Description = "Mutes a player by name or SteamID, preventing them from using text chat or VoIP.")]
		public static void MutePlayer(string id, string durText, string notes)
		{
			if (long.TryParse(durText, out long duration) && CLib.TryFindPlayerFromText(id, out Client cl) && cl.IsValid())
				Manager.Ban(cl, duration, notes);
		}

		[Command("unmute", "player.mute", Description = "Unmutes a previously muted player by name or SteamID.")]
		public static void UnmutePlayer(string id)
		{
			if (CLib.TryFindPlayerFromText(id, out Client cl))
				Manager.Unmute(cl);
			else if (long.TryParse(id, out long plyId))
				Manager.Unmute(plyId);
		}
	}
}
