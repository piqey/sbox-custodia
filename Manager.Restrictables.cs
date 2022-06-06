using System.Linq;
using Sandbox;

namespace Custodia
{
	public static partial class Manager
	{
		/// <summary>
		/// Be sure to include this check in your <see cref="Sandbox.Game.ClientJoined" /> override.
		/// </summary>
		/// <param name="cl">The <see cref="Client" /> whose connection privileges to assess.</param>
		/// <returns>Whether or not a player is permitted by Custodia to join the game.</returns>
		public static bool CanPlayerJoin(Client cl) =>
			!Bans.Where(b => cl.PlayerId == b.PlayerId).Any();

		/// <summary>
		/// Be sure to include this check in your <see cref="Sandbox.Game.CanHearPlayerVoice" /> override.
		/// </summary>
		/// <param name="cl">The <see cref="Client" /> whose voice chat privileges to assess.</param>
		/// <returns>Whether or not a player is permitted by Custodia to communicate via voice chat.</returns>
		public static bool CanPlayerVoice(Client cl) =>
			!Mutes.Where(b => cl.PlayerId == b.PlayerId).Any();
	}
}
