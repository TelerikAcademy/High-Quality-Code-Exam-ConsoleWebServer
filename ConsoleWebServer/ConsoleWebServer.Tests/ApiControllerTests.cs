namespace ConsoleWebServer.Tests
{
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
            var request = new Mock<IHttpRequest>("GET", "/", "1.1");
            var actionResult = new ApiController(request.Object);
            var resultBody = actionResult.ReturnMe(Parameter).GetResponse().Body;
            Assert.AreEqual(string.Format("{{\"param\":\"{0}\"}}", Parameter), resultBody);
        }

        // TODO: Add unit tests for ReturnMe and GetDateWithCors
    }
}
