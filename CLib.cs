using System;
// using System.Collections.Generic;
using System.Linq;
using Sandbox;
// using Steamworks;

namespace Custodia
{
	public static class CLib
	{
		public static ulong UnixNow => TimeToUnix(DateTime.UtcNow);

		public static ulong TimeToUnix(DateTime date) =>
			(ulong)(date - DateTime.UnixEpoch).TotalSeconds;

		public static Client FindPlayerFromText(string words)
		{
			Client clFromName = Client.All.FirstOrDefault(c => c.Name.Contains(words));

			if (!clFromName.IsValid() && ulong.TryParse(words, out ulong provided))
				return Client.All.FirstOrDefault(c => c.SteamId == provided);
			else
				return clFromName;
		}
	}
}
