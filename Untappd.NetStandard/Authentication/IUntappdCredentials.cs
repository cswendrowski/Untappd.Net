using System.Collections.Generic;

namespace Untappd.NetStandard.Authentication
{
	public interface IUntappdCredentials
	{
		IReadOnlyDictionary<string, string> AuthenticationData { get; }
	}
}