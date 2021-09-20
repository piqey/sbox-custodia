using System;
using System.Collections.Generic;
using System.Text.Json;
using Sandbox;

namespace Custodia
{
	public static partial class Manager
	{
		static Manager()
		{
			Game.OnClientJoined += CanPlayerJoin;
			Game.OnCanHearPlayerVoice += CanPlayerSpeak;
		}
	}
}
