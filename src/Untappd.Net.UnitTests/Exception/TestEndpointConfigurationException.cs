using NUnit.Framework;
using Untappd.NetStandard.Exception;

namespace Untappd.NetStandard.UnitTests.Exception
{
	[TestFixture]
	public class TestEndpointConfigurationException
	{
		[Test]
		[ExpectedException(typeof(EndpointConfigurationException), ExpectedMessage = "Invalid endpoint configured")]
		public void TestThrownExeption()
		{
			throw new EndpointConfigurationException();
		}
	}
}