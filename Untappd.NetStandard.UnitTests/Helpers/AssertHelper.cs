using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Untappd.NetStandard.UnitTests.Extensions
{
    public static class AssertHelper
    {
        public static void IsNotNullOrEmpty(string toCheck)
        {
            Assert.IsNotNull(toCheck);
            Assert.IsNotEmpty(toCheck);
        }
    }
}
