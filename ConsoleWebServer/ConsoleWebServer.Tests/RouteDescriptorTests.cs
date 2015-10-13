namespace ConsoleWebServer.Tests
{
    using ConsoleWebServer.Framework;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RouteDescriptorTests
    {
        [TestMethod]
        public void ConstructorWithNullRequestStringShouldSetDefaultNames()
        {
            var routeDescriptor = new RouteDescriptor(null);
            Assert.AreEqual(RouteDescriptor.DefaultControllerName, routeDescriptor.ControllerName);
            Assert.AreEqual(RouteDescriptor.DefaultActionName, routeDescriptor.ActionName);
            Assert.IsNull(routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithEmptyRequestStringShouldSetDefaultNames()
        {
            var routeDescriptor = new RouteDescriptor(string.Empty);
            Assert.AreEqual(RouteDescriptor.DefaultControllerName, routeDescriptor.ControllerName);
            Assert.AreEqual(RouteDescriptor.DefaultActionName, routeDescriptor.ActionName);
            Assert.IsNull(routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithSlashShouldSetDefaultNames()
        {
            var routeDescriptor = new RouteDescriptor("/");
            Assert.AreEqual(RouteDescriptor.DefaultControllerName, routeDescriptor.ControllerName);
            Assert.AreEqual(RouteDescriptor.DefaultActionName, routeDescriptor.ActionName);
            Assert.IsNull(routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithSlashStringShouldSetCorrectValues()
        {
            var routeDescriptor = new RouteDescriptor("/test");
            Assert.AreEqual("test", routeDescriptor.ControllerName);
            Assert.AreEqual(RouteDescriptor.DefaultActionName, routeDescriptor.ActionName);
            Assert.IsNull(routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithSlashStringSlashShouldSetCorrectValues()
        {
            var routeDescriptor = new RouteDescriptor("/test/");
            Assert.AreEqual("test", routeDescriptor.ControllerName);
            Assert.AreEqual(RouteDescriptor.DefaultActionName, routeDescriptor.ActionName);
            Assert.IsNull(routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithSlashStringSlashStringShouldSetCorrectValues()
        {
            var routeDescriptor = new RouteDescriptor("/test/method");
            Assert.AreEqual("test", routeDescriptor.ControllerName);
            Assert.AreEqual("method", routeDescriptor.ActionName);
            Assert.IsNull(routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithSlashStringSlashStringSlashShouldSetCorrectValues()
        {
            var routeDescriptor = new RouteDescriptor("/test/method/");
            Assert.AreEqual("test", routeDescriptor.ControllerName);
            Assert.AreEqual("method", routeDescriptor.ActionName);
            Assert.IsNull(routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithSlashStringSlashStringSlashIntShouldSetCorrectValues()
        {
            var routeDescriptor = new RouteDescriptor("/test/method/123");
            Assert.AreEqual("test", routeDescriptor.ControllerName);
            Assert.AreEqual("method", routeDescriptor.ActionName);
            Assert.AreEqual(123, routeDescriptor.Id);
        }

        [TestMethod]
        public void ConstructorWithSlashStringSlashStringSlashIntSlashShouldSetCorrectValues()
        {
            var routeDescriptor = new RouteDescriptor("/test/method/123/");
            Assert.AreEqual("test", routeDescriptor.ControllerName);
            Assert.AreEqual("method", routeDescriptor.ActionName);
            Assert.AreEqual(123, routeDescriptor.Id);
        }
    }
}
