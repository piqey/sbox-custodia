// using System;
using System.Collections.Generic;
using Sandbox;
// using Steamworks;

namespace Custodia
{
	public static partial class Manager
	{
		public static List<PunishmentData> Bans { get; } = new();

		public static void Kick(Client cl)
		{
			cl.Kick();
		}

		/// <summary>
		/// Kicks a <see cref="Client" /> from the game and prevents them from rejoining for a
		/// specified period of time.
		/// </summary>
		/// <param name="cl">The <see cref="Client" /> to be banned.</param>
		/// <param name="duration">The time in seconds this player should be banned for.</param>
		/// <param name="notes">Text to include with the ban data. Typically the reason for the ban.</param>
		public static void Ban(Client cl, long duration, string notes)
		{
			PunishmentData data = new(cl.PlayerId, duration, notes);
			Bans.Add(data);

			cl.Kick();
		}

		/// <summary>
		/// Prevents a SteamID64 from joining for a specified period of time.
		/// </summary>
		/// <param name="plyId">The SteamID64 to add to the banlist.</param>
		/// <param name="duration">The time in seconds this player should be banned for.</param>
		/// <param name="notes">Text to include with the ban data. Typically the reason for the ban.</param>
		public static void Ban(long plyId, long duration, string notes)
		{
			PunishmentData data = new(plyId, duration, notes);
			Bans.Add(data);
		}

		/// <summary>
		/// Removes a <see cref="Client" /> from the ban list.
		/// </summary>
		/// <param name="cl">The <see cref="Client" /> to be unbanned.</param>
		public static void Unban(Client cl) =>
			Bans.RemoveAll(d => d.PlayerId == cl.PlayerId);

		/// <summary>
		/// Removes an entry from the ban list via SteamID64.
		/// </summary>
		/// <param name="id">The SteamID64 to find and remove from the ban list.</param>
		public static void Unban(long id) =>
			Bans.RemoveAll(d => d.PlayerId == id);
	}
}
