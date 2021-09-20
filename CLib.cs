using System;
using System.Collections.Generic;
using System.Linq;
using Sandbox;
// using Steamworks;

namespace Custodia
{
	public static class CLib
	{
		public static long UnixNow => (long)(DateTime.UtcNow - DT).TotalSeconds;		

		private static DateTime DT { get; } = new(1970, 1, 1, 0, 0, 0);

		public static Client FindPlayerFromText(string words)
		{
			if (ulong.TryParse(words, out ulong provided))
				return Client.All.FirstOrDefault(c => c.SteamId == provided);
			else
				return Client.All.FirstOrDefault(c => c.Name.Contains(words));
		}
	}
}
