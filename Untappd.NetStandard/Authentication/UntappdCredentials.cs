using System.Collections.Generic;

namespace Untappd.NetStandard.Authentication
{
	public abstract class UntappdCredentials : IUntappdCredentials
	{
		public IReadOnlyDictionary<string, string> AuthenticationData { get; protected set; }
	}
}