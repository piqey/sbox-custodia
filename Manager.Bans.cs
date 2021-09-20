// using System;
using System.Collections.Generic;
using Sandbox;
using Steamworks;

namespace Custodia
{
	public readonly struct BanData
	{
		public readonly SteamId SteamId;
		public readonly ulong ExpiryTime;
		public readonly string Notes;

		public readonly ulong Timestamp;

		public ulong TimeRemaining => ExpiryTime - CLib.UnixNow;

		#nullable enable

		public BanData(SteamId id, float duration, string? notes)
		{
			SteamId = id;
			Notes = notes ?? string.Empty;

			Timestamp = CLib.UnixNow;
			ExpiryTime = Timestamp + (ulong)(duration * 3600.0f);
		}

		#nullable disable
	}

	public static partial class Manager
	{
		public static List<BanData> Bans { get; } = new();

		#nullable enable

		public static void Ban(Client cl, float duration, string? notes)
		{
			BanData data = new(cl.SteamId, duration, notes);
			Bans.Add(data);
		}

		#nullable disable
	}
}
