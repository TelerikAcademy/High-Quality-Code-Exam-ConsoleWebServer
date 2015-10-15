namespace ConsoleWebServer.Tests
{
    using System;
    using System.Linq;

    using ConsoleWebServer.Application.Controllers;
    using ConsoleWebServer.Framework;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    [TestClass]
    public class ApiControllerTests
    {
        [TestMethod]
        public void ReturnMeActionReturnsParameterInTheJsonObject()
        {
            const string Parameter = "someParam123";
            var request = new Mock<IHttpRequest>();
            request.Setup(x => x.ProtocolVersion).Returns(new Version(1, 1));
            var actionResult = new ApiController(request.Object);
            var resultBody = actionResult.ReturnMe(Parameter).GetResponse().Body;
            Assert.AreEqual(string.Format("{{\"param\":\"{0}\"}}", Parameter), resultBody);
        }

        [TestMethod]
        public void ReturnMeActionReturnsJsonContentType()
        {
            const string Parameter = "someParam123";
            var request = new Mock<IHttpRequest>();
            request.Setup(x => x.ProtocolVersion).Returns(new Version(1, 1));
            var actionResult = new ApiController(request.Object);
            var contentType = actionResult.ReturnMe(Parameter).GetResponse().Headers["Content-Type"].First();
            Assert.AreEqual("application/json", contentType);
        }

        // TODO: Add unit tests for ReturnMe and GetDateWithCors
    }
}
