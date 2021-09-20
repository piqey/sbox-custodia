using System;
using System.Collections.Generic;
using Sandbox;

namespace Custodia
{
	public readonly struct BanData
	{
		public readonly string SteamID;
		public readonly float Duration;
		public readonly string Notes;

		public readonly long Timestamp;

		#nullable enable

		public BanData(string id, float duration, string? notes)
		{
			SteamID = id;
			Duration = duration;
			Notes = notes ?? string.Empty;

			Timestamp = CLib.UnixNow;
		}

		#nullable disable
	}

	public static partial class Manager
	{
		public static List<BanData> BanData { get; } = new();

		#nullable enable

		public static void Ban(Client cl, float duration, string? notes)
		{
			throw new NotImplementedException();
		}

		#nullable disable
	}
}
