// using System;
using System.Collections.Generic;
using Sandbox;
// using Steamworks;

namespace Custodia
{
	public static partial class Manager
	{
		public static List<PunishmentData> Mutes { get; } = new();

		public static void Mute(Client cl, long duration, string notes)
		{
			PunishmentData data = new(cl.PlayerId, duration, notes);
			Mutes.Add(data);
		}

		public static void Unmute(Client cl) =>
			Mutes.RemoveAll(d => d.PlayerId == cl.PlayerId);

		public static void Unmute(long id) =>
			Mutes.RemoveAll(d => d.PlayerId == id);
	}
}
