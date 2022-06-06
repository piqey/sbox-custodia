using Sandbox;

namespace Custodia
{
	public partial class Game : Sandbox.Game
	{
		/********************************
		* SANDBOX.GAME METHOD OVERRIDES *
		*********************************/

		public override void ClientJoined(Client cl)
		{
			if (Manager.CanPlayerJoin(cl))
				base.ClientJoined(cl);
			else
				cl.Kick();
		}

		public override bool CanHearPlayerVoice(Client speaker, Client listener) =>
			base.CanHearPlayerVoice(speaker, listener) && Manager.CanPlayerVoice(speaker);
	}
}
