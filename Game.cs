using System;
using Sandbox;

namespace Custodia
{
	public partial class Game : Sandbox.Game
	{
		/**************
		*   EVENTS    *
		* (ANONYMOUS) *
		***************/

		/// <summary>
		/// Invoked once the level has finished loading and entities have
		/// been spawned.
		/// </summary>
		/// <see cref="PostLevelLoaded" />
		public static event Action OnPostLevelLoaded;

		/// <summary>
		/// Invoked at the time a client joins to determine whether or not
		/// they should be permitted to enter the game. Return false if they
		/// should not be.
		/// </summary>
		/// <see cref="ClientJoined" />
		public static event Action<CustodiaEventArgs> OnClientJoined;

		/// <summary>
		/// Invoked to determine whether or not a player's voice chat should
		/// be permitted to be sent to others. Return false if this player's
		/// voice should be blocked.
		/// </summary>
		/// <see cref="CanHearPlayerVoice" />
		public static event Action<CustodiaEventArgs> OnCanHearPlayerVoice;

		/****************
		*    EVENTS     *
		* (INVOCATIONS) *
		*****************/

		public override void PostLevelLoaded()
		{
			base.PostLevelLoaded();

			OnPostLevelLoaded?.Invoke();
		}

		public override void ClientJoined(Client cl)
		{
			if (CheckRestrictedEvents(cl, OnClientJoined) ?? false)
				cl.Kick();
			else
				base.ClientJoined(cl);
		}

		public override bool CanHearPlayerVoice(Client speaker, Client listener) =>
			(!CheckRestrictedEvents(speaker, OnCanHearPlayerVoice) ?? true) && base.CanHearPlayerVoice(speaker, listener);
		
		protected virtual bool? CheckRestrictedEvents(Client client, Action<CustodiaEventArgs> action)
		{
			CustodiaEventArgs eArgs = new() { Client = client };
			action?.Invoke(eArgs);

			return eArgs.Restrict;
		}
	}
}
