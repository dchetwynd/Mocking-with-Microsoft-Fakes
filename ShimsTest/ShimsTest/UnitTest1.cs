using System;
using System.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using NUnit.Framework;

namespace ShimsTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CanOverrideDateTime()
        {
            using (ShimsContext.Create())
            {
                ShimDateTime.NowGet = () =>
                {
                    return new DateTime(2012, 2, 29);
                };

                Assert.That(DateTime.Now, Is.EqualTo(new DateTime(2012, 2, 29)));
            }
        }

        [Test]
        public void CanOverrideNewGuid()
        {
            using (ShimsContext.Create())
            {
                const string GUID_VALUE = "11111111-2222-3333-4444-555555555555";

                ShimGuid.NewGuid = () =>
                {
                    return new Guid(GUID_VALUE);
                };

                Assert.That(Guid.NewGuid(), Is.EqualTo(new Guid(GUID_VALUE)));
            }
        }
    }
}
