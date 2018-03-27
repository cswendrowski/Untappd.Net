using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Untappd.NetStandard.Request;
using Untappd.NetStandard.UnitTests.Extensions;

namespace Untappd.NetStandard.UnitTests.Responses
{
	[TestFixture]
	public class TestResponseEndpoints
	{
		/// <summary>
		/// Run through all the endpoints to make sure they all atleast do not error out.
		/// This is so we can get a high code coverage, while also covering new types that get added.
		/// </summary>
		[Test]
		public void RunAllEndpoints()
		{
			var objects = Assembly.GetAssembly(typeof(IRequest)).GetTypes().Where(myType =>
			   myType.IsClass
			   && !myType.IsAbstract
			   && myType.GetInterface("IRequest") != null).Select(type => (IRequest)Activator.CreateInstance(type)).ToList();
			objects.ForEach(a => AssertHelper.IsNotNullOrEmpty(a.EndPoint("t")));
		}

		[Test]
		public void RunAllEndpointsWithEmptyString()
		{
			var objects = Assembly.GetAssembly(typeof(IRequest)).GetTypes().Where(myType =>
			   myType.IsClass
			   && !myType.IsAbstract
			   && myType.GetInterface("IRequest") != null).Select(type => (IRequest)Activator.CreateInstance(type)).ToList();
			objects.ForEach(a => AssertHelper.IsNotNullOrEmpty(a.EndPoint(string.Empty)));
		}
	}
}