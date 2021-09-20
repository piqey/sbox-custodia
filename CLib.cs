using System;
using System.Collections.Generic;
using System.Linq;
using Sandbox;

namespace Custodia
{
	public static class CLib
	{
		public static long UnixNow => (long)(DateTime.UtcNow - DT).TotalSeconds;		

		private static DateTime DT { get; } = new(1970, 1, 1, 0, 0, 0);

		#nullable enable

		public static Client? FindPlayerFromText(string words) =>
			Client.All.FirstOrDefault(c => c.Name.Contains(words));

		#nullable disable
	}
}
