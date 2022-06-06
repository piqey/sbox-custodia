using System;

namespace Custodia
{
	public readonly struct PunishmentData
	{
		public readonly long PlayerId;
		public readonly long ExpiryUnix;
		public readonly string Notes;

		public readonly long Timestamp;

		public long TimeRemaining => ExpiryUnix - CLib.UnixNow;

		public DateTime ExpiryUTC => CLib.UnixToDateTime(ExpiryUnix);
		public DateTime ExpiryLocal => CLib.UnixToDateTime(ExpiryUnix, true);

		public PunishmentData(long id, long duration, string notes = "")
		{
			PlayerId = id;
			Notes = notes;

			Timestamp = CLib.UnixNow;
			ExpiryUnix = Timestamp + duration;
		}
	}
}
