using System;
using System.Linq;
using Sandbox;

namespace Custodia
{
	public static class CLib
	{
		/*****************
		* TIME UTILITIES *
		******************/

		/// <summary>
		/// The current Unix timestamp (seconds since 01/01/1970 00:00).
		/// </summary>
		public static long UnixNow => DateTimeOffset.Now.ToUnixTimeSeconds();

		/// <summary>
		/// Converts a Unix timestamp into a <see cref="DateTime" /> object.
		/// </summary>
		/// <param name="unix">The Unix timestamp to convert.</param>
		/// <param name="local">If <see langword="true" />, returns local time rather than UTC.</param>
		/// <returns>The <see cref="DateTime" /> equivalent of the provided Unix time.</returns>
		public static DateTime UnixToDateTime(long unix, bool local = false)
		{
			DateTimeOffset dto = DateTimeOffset.FromUnixTimeSeconds(unix);
			return local ? dto.LocalDateTime : dto.UtcDateTime;
		}

		/******************
		* MISC. UTILITIES *
		*******************/

		public static bool TryFindPlayerFromText(string words, out Client cl)
		{
			if (long.TryParse(words, out long provided))
				cl = Client.All.FirstOrDefault(c => c.PlayerId == provided);
			else
				cl = Client.All.FirstOrDefault(c => c.Name.Contains(words));

			return cl.IsValid();
		}
	}
}
