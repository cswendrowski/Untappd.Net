using NUnit.Framework;
using Untappd.NetStandard.Exception;

namespace Untappd.NetStandard.UnitTests.Exception
{
	[TestFixture]
	public class TestBaseUntappdException
	{
		[ExpectedException(typeof(BaseUntappdException))]
		[Test]
		public void TestStandardException()
		{
			throw new BaseUntappdException();
		}

		[ExpectedException(typeof(BaseUntappdException), ExpectedMessage = "messageHere")]
		[Test]
		public void TestStandardExceptionWithMessage()
		{
			throw new BaseUntappdException("messageHere");
		}

		[ExpectedException(typeof(BaseUntappdException), ExpectedMessage = "messageHere")]
		[Test]
		public void TestStandardExceptionWithInner()
		{
			throw new BaseUntappdException("messageHere", new System.Exception("innerException!"));
		}
	}
}