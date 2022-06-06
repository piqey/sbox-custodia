// using System;
using System.Collections.Generic;
using Sandbox;
// using Steamworks;

namespace Custodia
{
	public static partial class Manager
	{
		public static List<PunishmentData> Bans { get; } = new();

		public static void Ban(Client cl, long duration, string notes)
		{
			PunishmentData data = new(cl.PlayerId, duration, notes);
			Bans.Add(data);
		}

		public static void Unban(Client cl) =>
			Bans.RemoveAll(d => d.PlayerId == cl.PlayerId);

		public static void Unban(long id) =>
			Bans.RemoveAll(d => d.PlayerId == id);
	}
}
