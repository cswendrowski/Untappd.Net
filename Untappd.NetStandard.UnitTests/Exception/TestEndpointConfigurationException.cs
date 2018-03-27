using NUnit.Framework;
using Untappd.NetStandard.Exception;

namespace Untappd.NetStandard.UnitTests.Exception
{
	[TestFixture]
	public class TestEndpointConfigurationException
	{
		[Test]
		[ExpectedException(typeof(EndpointConfigurationException))]
		public void TestThrownExeption()
		{
			throw new EndpointConfigurationException();
		}
	}
}