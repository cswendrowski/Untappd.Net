﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Untappd.NetStandard.Authentication;
using Assert = NUnit.Framework.Assert;

namespace Untappd.NetStandard.UnitTests.Authentication
{
	[TestFixture]
	public class TestAuthenticatedUntappdCredentials
	{
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ExpectException()
		{
			var t = new AuthenticatedUntappdCredentials(null);
		}

		[Test]
		public void ExpectValid()
		{
			var token = "awesome";
			var t = new AuthenticatedUntappdCredentials(token);
			Assert.AreEqual(token, "awesome");
			token = "newString";
			//Make sure the reference is not copied over
			Assert.AreEqual("awesome", t.AuthenticationData["access_token"]);
		}
	}
}